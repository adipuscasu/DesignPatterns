
using LiskovSubstitutionPrinciple.Models;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        private static int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            System.Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            System.Console.WriteLine($"{sq} has area {Area(sq)}");
            // you should always be able to substitute a base type for a subtype
        }
    }
}
