# ComponentPen 

`ComponentPen` is a Blazor component named, which mimics the functionality of [CodePen](https://codepen.io/) within a Blazor application. It allows users to input HTML, CSS, and JavaScript code, render the output dynamically, and interact with saved components. Below is a detailed analysis of how this component works and the advanced techniques it employs.

## Overview

`ComponentPen` provides an interface for users to write and preview Blazor components on-the-fly. It leverages advanced Blazor features such as dynamic component rendering, reflection, JavaScript interop, and state management using browser storage. The component consists of a user interface built with Radzen Blazor components and a code-behind that handles dynamic rendering and state persistence.

## Detailed Analysis

### Using Statements and Dependency Injection

```csharp
@using Microsoft.AspNetCore.Components
@using Microsoft.AspNetCore.Components.Rendering
@using Microsoft.JSInterop
@using System.Reflection
@using System.Linq
@using System.Text.RegularExpressions
@using Radzen
@using Radzen.Blazor
@inject IJSRuntime JSRuntime
@inject NotificationService NotificationService
```

- **Blazor and System Namespaces**: Essential for building Blazor components, rendering content, and using reflection.
- **Radzen Components**: Provide UI elements like `RadzenCard`, `RadzenTabs`, `RadzenSplitter`, etc.
- **Dependency Injection**: Injects `IJSRuntime` for JavaScript interop and `NotificationService` for displaying notifications.

### UI Layout with Radzen Components

The component's UI is structured using Radzen components:

- **Header**: Displays the component title using `RadzenCard` and `RadzenStack`.
- **Component Name Input**: Allows users to select or enter a component name using `RadzenDropDown` and `RadzenTextBox`.
- **Save and Load Buttons**: Use `RadzenButton` to trigger save and load operations.
- **Code Editors**: Three tabs (`HTML`, `CSS`, `JavaScript`) implemented with `RadzenTabs` and `RadzenTextArea` for code input.
- **Preview Pane**: Displays either the rendered output or the generated Razor code, switchable via `RadzenSelectBar`.

### Component State Variables

```csharp
private string componentName = string.Empty;
private string selectedComponentName = string.Empty;
private string htmlInput = @"<h3>Hello, Blazor!</h3>...";
private string cssInput = "h3 { color: blue; }";
private string jsInput = "console.log('JavaScript executed!');";
private string selectedView = "preview";
private string generatedRazorCode = "intentionally blank";
private const string constPreview = "preview";
private const string constSource = "source";
private int selectedTabIndex = 0;

private RenderFragment renderFragment;
private Dictionary<string, Type> _componentTypes;
private List<string> savedComponentNames = new List<string>();
```

- **User Inputs**: Stores the component name and code inputs for HTML, CSS, and JavaScript.
- **View State**: Manages which view is currently selected (`preview` or `source`) and the active tab index.
- **Render Fragment**: A dynamic render fragment (`renderFragment`) used to render the user input.
- **Component Types Dictionary**: Maps component names to their `Type` using reflection.
- **Saved Component Names**: A list of saved components retrieved from `localStorage`.

### Lifecycle Methods

#### OnInitializedAsync

```csharp
protected override async Task OnInitializedAsync()
{
    var assembly = Assembly.GetExecutingAssembly();
    _componentTypes = assembly.GetTypes()
        .Where(t => typeof(ComponentBase).IsAssignableFrom(t) && !t.IsAbstract)
        .ToDictionary(t => t.Name, t => t);

    await LoadSavedComponentNames();
}
```

- **Reflection**: Uses reflection to get all non-abstract types derived from `ComponentBase` in the current assembly. Stores them in `_componentTypes` for dynamic instantiation.
- **Load Saved Names**: Calls `LoadSavedComponentNames` to populate `savedComponentNames` from `localStorage`.

#### OnAfterRenderAsync

```csharp
protected override async Task OnAfterRenderAsync(bool firstRender)
{
    if (firstRender)
    {
        await JSRuntime.InvokeVoidAsync("eval", @"
            window.setupCodeEditor = function() {
                console.log('Code editor setup complete');
            };

            window.updateCodeEditor = function(index) {
                console.log('Switched to tab index: ' + index);
            };
        ");

        await JSRuntime.InvokeVoidAsync("setupCodeEditor");
    }
}
```

- **JavaScript Interop**: Injects JavaScript functions into the page context using `eval`.
- **First Render Check**: Ensures the setup code runs only once during the component's initial render.

### Event Handlers

#### OnDropDownChange

```csharp
private void OnDropDownChange(object value)
{
    if (value != null)
    {
        componentName = value.ToString();
    }
}
```

- **Component Name Synchronization**: Updates `componentName` when the user selects a component from the dropdown.

#### OnTabChange

```csharp
private async Task OnTabChange(int index)
{
    selectedTabIndex = index;
    await JSRuntime.InvokeVoidAsync("updateCodeEditor", index);
}
```

- **Tab Change Handling**: Updates the `selectedTabIndex` and notifies the JavaScript function `updateCodeEditor`.

### UpdatePreview Method

```csharp
private void UpdatePreview()
{
    generatedRazorCode = GenerateRazorComponentCode();

    renderFragment = builder =>
    {
        var sequence = 0;
        builder.OpenElement(sequence++, "style");
        builder.AddContent(sequence++, cssInput);
        builder.CloseElement();
        RenderContent(builder, ref sequence, htmlInput);
        JSRuntime.InvokeVoidAsync("eval", jsInput);
    };
}
```

- **Dynamic Render Fragment**: Constructs a `RenderFragment` that includes the CSS styles, renders the HTML content, and executes JavaScript code.
- **JavaScript Execution**: Uses `eval` to execute user-provided JavaScript code, which is an advanced but potentially unsafe practice.

### RenderContent Method

```csharp
private void RenderContent(RenderTreeBuilder builder, ref int sequence, string content)
{
    var remainingContent = content;

    while (!string.IsNullOrEmpty(remainingContent))
    {
        var componentMatch = _componentTypes.Keys
            .Select(tag => new { Tag = tag, Index = remainingContent.IndexOf($"<{tag}", StringComparison.OrdinalIgnoreCase) })
            .Where(m => m.Index != -1)
            .OrderBy(m => m.Index)
            .FirstOrDefault();

        if (componentMatch == null)
        {
            builder.AddMarkupContent(sequence++, remainingContent);
            break;
        }

        if (componentMatch.Index > 0)
        {
            builder.AddMarkupContent(sequence++, remainingContent.Substring(0, componentMatch.Index));
        }

        var tagCloseIndex = remainingContent.IndexOf("/>", componentMatch.Index, StringComparison.OrdinalIgnoreCase);
        var componentHtml = remainingContent.Substring(componentMatch.Index, tagCloseIndex - componentMatch.Index + 2);
        var componentType = _componentTypes[componentMatch.Tag];

        builder.OpenComponent(sequence++, componentType);
        builder.CloseComponent();

        remainingContent = remainingContent.Substring(tagCloseIndex + 2);
    }
}
```

- **Custom HTML Parsing**: Parses the HTML input to find custom component tags matching known component types.
- **Dynamic Component Rendering**: Uses `RenderTreeBuilder` to dynamically instantiate and render components found in the HTML input.
- **Markup Content**: Adds regular HTML content directly using `AddMarkupContent`.

### SaveComponent and LoadComponent Methods

#### SaveComponent

```csharp
private async Task SaveComponent()
{
    if (string.IsNullOrWhiteSpace(componentName))
    {
        NotificationService.Notify(NotificationSeverity.Error, "Error", "Please enter a component name before saving.");
        return;
    }

    var componentData = new
    {
        ComponentName = componentName,
        HtmlInput = htmlInput,
        CssInput = cssInput,
        JsInput = jsInput
    };

    var jsonData = System.Text.Json.JsonSerializer.Serialize(componentData);
    await JSRuntime.InvokeVoidAsync("localStorage.setItem", componentName, jsonData);

    if (!savedComponentNames.Contains(componentName))
    {
        savedComponentNames.Add(componentName);
        await SaveComponentNames();
    }

    NotificationService.Notify(NotificationSeverity.Success, "Success", $"Component '{componentName}' saved successfully!");
    await JSRuntime.InvokeVoidAsync("navigator.clipboard.writeText", generatedRazorCode);
    NotificationService.Notify(NotificationSeverity.Info, "Info", "Razor component code copied to clipboard!");
}
```

- **Input Validation**: Checks if a component name is provided.
- **State Persistence**: Saves the component's data to `localStorage` using JavaScript interop.
- **Clipboard Interaction**: Copies the generated Razor code to the clipboard.
- **Notifications**: Provides user feedback using `NotificationService`.

#### LoadComponent

```csharp
private async Task LoadComponent()
{
    if (string.IsNullOrWhiteSpace(componentName))
    {
        NotificationService.Notify(NotificationSeverity.Error, "Error", "Please select or enter a component name to load.");
        return;
    }

    var jsonData = await JSRuntime.InvokeAsync<string>("localStorage.getItem", componentName);
    if (jsonData == null)
    {
        NotificationService.Notify(NotificationSeverity.Error, "Error", $"No saved component found with the name '{componentName}'.");
        return;
    }

    try
    {
        var componentData = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(jsonData);

        if (componentData != null)
        {
            htmlInput = componentData["HtmlInput"];
            cssInput = componentData["CssInput"];
            jsInput = componentData["JsInput"];

            NotificationService.Notify(NotificationSeverity.Success, "Success", $"Component '{componentName}' loaded successfully!");
            StateHasChanged();
        }
    }
    catch (Exception ex)
    {
        NotificationService.Notify(NotificationSeverity.Error, "Error", $"Error loading component: {ex.Message}");
    }
}
```

- **State Retrieval**: Fetches the component's data from `localStorage`.
- **Error Handling**: Catches exceptions during deserialization and notifies the user.
- **State Update**: Updates the component's state and triggers a re-render with `StateHasChanged`.

### GenerateRazorComponentCode Method

```csharp
private string GenerateRazorComponentCode()
{
    return $@"
@page ""/{componentName.ToLower()}""
@using Microsoft.AspNetCore.Components
@using Microsoft.JSInterop

<div class=""{componentName.ToLower()}-container"">
    {htmlInput}
</div>

<style>
    {cssInput}
</style>

<script>
    {jsInput}
</script>

@code {{
    // Your code-behind logic can be added here
}}
";
}
```

- **Code Generation**: Constructs a Razor component code as a string, incorporating user inputs.
- **Template Usage**: Uses string interpolation to insert values into a predefined Razor component template.

## Advanced Techniques Employed

### 1. Dynamic Component Rendering with RenderTreeBuilder

- **Dynamic Content**: The use of `RenderTreeBuilder` allows for dynamic rendering of components at runtime based on user input.
- **Custom HTML Parsing**: Parses the HTML input to identify component tags that correspond to known Blazor components.
- **Sequence Management**: Manages the `sequence` parameter in `RenderTreeBuilder` methods to ensure proper rendering.

### 2. Reflection for Component Discovery

- **Type Inspection**: Uses reflection to discover all available Blazor components in the assembly.
- **Component Mapping**: Creates a dictionary mapping component names to their `Type`, enabling dynamic instantiation.

### 3. JavaScript Interoperability

- **Executing JavaScript Code**: Executes user-provided JavaScript code using `JSRuntime.InvokeVoidAsync("eval", jsInput)`.
- **Defining JavaScript Functions**: Injects JavaScript functions into the page context for code editor setup and interaction.
- **LocalStorage Interaction**: Saves and retrieves data from the browser's `localStorage` via JavaScript interop.

### 4. State Management with Browser Storage

- **Persistence**: Saves user-generated components and their code to `localStorage`, enabling persistence across sessions.
- **Serialization**: Serializes and deserializes component data using `System.Text.Json.JsonSerializer`.

### 5. Clipboard Interaction

- **Copying to Clipboard**: Uses JavaScript interop to copy the generated Razor code to the user's clipboard.

### 6. User Feedback with Notifications

- **NotificationService**: Provides real-time feedback to the user for actions like saving, loading, and errors.

### 7. UI Composition with Radzen Components

- **Rich UI Elements**: Leverages Radzen components for a professional and responsive user interface.
- **Tab Management**: Uses `RadzenTabs` to switch between code editors.
- **Splitter Pane**: Implements a resizable split view using `RadzenSplitter`.

## Security Considerations

- **JavaScript Execution Risk**: Using `eval` to execute arbitrary JavaScript code poses significant security risks, such as cross-site scripting (XSS) attacks.
- **Input Sanitization**: The component should implement input sanitization to prevent injection attacks through user-provided HTML and JavaScript.

## Conclusion

The `ComponentPen` Blazor component is a sophisticated tool that brings dynamic code editing and previewing capabilities to Blazor applications. It demonstrates several advanced techniques:

- **Dynamic Rendering**: Using `RenderTreeBuilder` and `RenderFragment` to render components and content based on user input.
- **Reflection**: Leveraging reflection to discover and instantiate components dynamically.
- **JavaScript Interop**: Executing JavaScript code and interacting with browser APIs like `localStorage` and the clipboard.
- **State Management**: Persisting user data across sessions using browser storage.
- **UI Composition**: Building a rich and interactive UI using Radzen Blazor components.

By integrating these advanced features, `ComponentPen` provides a powerful platform for experimenting with Blazor components and code in real-time, akin to what CodePen offers for web technologies.