using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class UserPrefs
    {
        private string _prefColor;
        private string _prefFont;

        private static UserPrefs singleton;

        private UserPrefs()
        {
            Console.WriteLine("Instantiated");
            PrefColor= string.Empty;
            PrefFont= string.Empty;
        }

        public string PrefFont { get => _prefFont; set => _prefFont = value; }
        public string PrefColor { get => _prefColor; set => _prefColor = value; }

        public static UserPrefs GetInstance()
        {
            if (singleton is null)
            {
                singleton = new UserPrefs();
            }
            return singleton;
        }


    }
}
