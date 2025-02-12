using InterfaceSegragationPrinciple.Interfaces;

namespace InterfaceSegragationPrinciple.Models
{
    internal class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            Console.WriteLine($"Faxing {d.ToString}");
        }

        public void Fax(System.Reflection.Metadata.Document d)
        {
            throw new NotImplementedException();
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
