using System.Text;

namespace AbstractFactory
{
    internal class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> _themes = [];
        public ITheme CreateTheme(bool dark)
        {
            ITheme theme = dark ? new DarkTheme() : new LightTheme();
            _themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }

        public string Info()
        {
            var sb = new StringBuilder();
            foreach (var theme in _themes)
            {
                if (theme.TryGetTarget(out var t))
                {
                    bool dark = t is DarkTheme;
                    sb.AppendLine(dark ? "Dark" : "Light")
                        .AppendLine($"Text color: {t.TextColor}")
                        .AppendLine($"Background color: {t.BackgroundColor}");
                }
            }
            return sb.ToString();
        }
    }
}
