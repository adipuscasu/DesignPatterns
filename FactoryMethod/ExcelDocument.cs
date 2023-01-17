using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ExcelDocument : Document
    {
        public override void Close()
        {
            Console.WriteLine($"{this.GetType()} is closed");
        }

        public override void Open()
        {
            Console.WriteLine($"{this.GetType()} is opened");

        }
    }
}