using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Document
    {
        // common methods for all documents
        public abstract void Open();

        public abstract void Close();
    }
}
