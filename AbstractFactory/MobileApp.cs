using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MobileApp : Application
    {
        public override Scrollbar CreateScrollbar()
        {
            return new MobileScrollbar();
        }

        public override MyWindow CreateWindow()
        {
            return new MobileWindow();
        }
    }
}
