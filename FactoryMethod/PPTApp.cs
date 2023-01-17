using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class PPTApp : OfficeApp
    {
        public override Document CreateDocument()
        {
            return new PPTDocument();
        }
    }
}
