using Coding.Exercise;

namespace FacetedBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb
                .Works
                    .At("Fabrikam")
                    .AsA("Engineer")
                    .Earning(123000)
                .Lives
                    .At("123 London Road")
                    .In("London")
                    .WithPostcode("SW12BC")
                .Build();
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}
