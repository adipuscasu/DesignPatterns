using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class DesktopWindow : MyWindow
    {
        public override void OpenWindow()
        {
            Console.WriteLine("Open Desktop Window");
        }
    }
}
