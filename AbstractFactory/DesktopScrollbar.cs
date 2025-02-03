using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class DesktopScrollbar : Scrollbar
    {
        public override void SetLocation(int x)
        {
            Console.WriteLine($"DesktopScrollbar Setting location to {x}");
        }
    }
}
