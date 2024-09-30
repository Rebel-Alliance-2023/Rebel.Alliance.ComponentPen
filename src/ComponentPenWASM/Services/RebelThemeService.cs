using ComponentPenWASM;
using System;

namespace ComponentPenWASM.Services
{
	public class RebelThemeService
	{
		private GradientTheme? currentTheme;
		private bool isDarkMode;

		public event Action? OnThemeChange;

		public void SetTheme(GradientTheme theme, bool darkMode)
		{
			currentTheme = theme;
			isDarkMode = darkMode;
			OnThemeChange?.Invoke();
		}

		public string GetCurrentGradient()
		{
			if (currentTheme == null)
			{
				return "";
			}
			return isDarkMode ? currentTheme.DarkModeGradient : currentTheme.LightModeGradient;
		}

		public string GetBodyBackgroundStyle()
		{
			var gradient = GetCurrentGradient();
			return $"background: {gradient};";
		}

		public string GetTextColor()
		{
			return isDarkMode ? "#ffffff" : "#000000";
		}

		public string GetComponentBackgroundColor()
		{
			return isDarkMode ? "rgba(0, 0, 0, 0.5)" : "rgba(255, 255, 255, 0.5)";
		}
	}
}
