using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class OfficeApp
    {
        public abstract Document CreateDocument();
        public void NewDocument()
        {
            Document doc = CreateDocument();
            // common steps for creating the document
            doc.Open();
        }
    }
}
