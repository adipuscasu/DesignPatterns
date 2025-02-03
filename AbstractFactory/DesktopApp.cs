using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class DesktopApp : Application
    {

        public override Scrollbar CreateScrollbar()
        {
            return new DesktopScrollbar();
        }

        public override MyWindow CreateWindow()
        {
            return new DesktopWindow();
        }
    }
}
