using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class WordApp : OfficeApp
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}
