using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ReplaceableThemeFactory
    {
        private readonly List<WeakReference<Ref<ITheme>>> _themes = [];
        public ITheme CreateThemeImpl(bool dark)
        {
            ITheme theme = dark ? new DarkTheme() : new LightTheme();
            return theme;
        }

        public Ref<ITheme> CreateTheme(bool dark)
        {
            var r = new Ref<ITheme>(CreateThemeImpl(dark));
            _themes.Add(new(r));
            return r;
        }

        public void ReplaceTheme(bool dark)
        {
            foreach (var theme in _themes)
            {
                if (theme.TryGetTarget(out var t))
                {
                    t.Value = CreateThemeImpl(dark);
                }
            }
        }
    }
}
