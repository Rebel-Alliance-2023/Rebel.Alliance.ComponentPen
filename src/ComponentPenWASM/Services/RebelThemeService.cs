using ComponentPenWASM;
using System;
using System.Text;

namespace ComponentPenWASM.Services
{
	public class RebelThemeService
	{
		private GradientTheme? currentTheme;
		private bool isDarkMode;

		public event Action? OnThemeChange;

		public GradientTheme? CurrentTheme => currentTheme;

		public void SetTheme(GradientTheme theme, bool darkMode)
		{
			currentTheme = theme;
			isDarkMode = darkMode;
			OnThemeChange?.Invoke();
		}

		public string GetColor(string colorKey)
		{
			if (currentTheme == null || !currentTheme.Palette.Colors.ContainsKey(colorKey))
			{
				return "#000000";
			}
			return currentTheme.Palette.Colors[colorKey];
		}

		public string GenerateThemeCssVariables()
		{
			if (currentTheme == null)
			{
				return string.Empty;
			}

			var sb = new StringBuilder();
			sb.AppendLine(":root {");
			foreach (var (key, value) in currentTheme.Palette.Colors)
			{
				sb.AppendLine($"  --theme-{key}: {value};");
			}
			sb.AppendLine("}");
			return sb.ToString();
		}

		public string GetBodyBackgroundStyle()
		{
			if (currentTheme == null)
			{
				return string.Empty;
			}
			string backgroundColor = isDarkMode ? GetColor("color1") : GetColor("color5");
			return $"background-color: {backgroundColor};";
		}

		public bool IsDarkMode => isDarkMode;
	}
}