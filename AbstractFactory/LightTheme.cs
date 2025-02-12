using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LightTheme: ITheme
    {
        public string TextColor => "Black";
        public string BackgroundColor => "White";
    }
}
