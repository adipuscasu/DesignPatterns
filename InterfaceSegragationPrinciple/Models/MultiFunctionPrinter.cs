using InterfaceSegragationPrinciple.Interfaces;

namespace InterfaceSegragationPrinciple.Models
{
    internal class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            Console.WriteLine($"Faxing {d.ToString}");
        }

        public void Print(Document d)
        {
            Console.WriteLine($"Printing {d}");
        }

        public void Scan(Document d)
        {
            Console.WriteLine($"Scanning {d}");
        }
    }
}
