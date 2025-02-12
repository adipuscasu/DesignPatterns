namespace FactoryMethod
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);

            var foo = await Foo.CreateAsync();

        }
    }
}
