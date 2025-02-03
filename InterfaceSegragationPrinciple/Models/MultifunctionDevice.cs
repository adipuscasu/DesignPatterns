using InterfaceSegragationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegragationPrinciple.Models
{
    internal class MultifunctionDevice : IMultifunction
    {

        private IPrinter printer;
        private IScanner scanner;

        public MultifunctionDevice(IPrinter printer, IScanner scanner)
        {
            this.printer = printer ?? throw new ArgumentNullException(nameof(printer));
            this.scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            // decorator pattern
            scanner.Scan(d);
        }
    }
}
