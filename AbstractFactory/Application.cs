using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Applicationdddddsfd
    {
        public abstract MyWindow CreateWindow();
        public abstract Scrollbar CreateScrollbar();

        public void Open()
        {
            MyWindow window = CreateWindow();
            Scrollbar scrollbar = CreateScrollbar();

            window.OpenWindow();
            scrollbar.SetLocation(1);
        }

    }
}
