namespace FunctionalBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Dmitri")
                .WorksAsA("Quant")
                .Build();
            Console.WriteLine(person);
        }
    }
}
