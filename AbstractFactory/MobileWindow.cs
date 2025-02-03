using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MobileWindow : MyWindow
    {

        public override void OpenWindow()
        {
            Console.WriteLine("Open MobileWindow Window");
        }
    }
}
