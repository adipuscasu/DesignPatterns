using FactoryMethod;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            var factory = new TrackingThemeFactory();
            var theme1 = factory.CreateTheme(false);
            var theme2 = factory.CreateTheme(true);
            Console.WriteLine(factory.Info());

            var replaceableFactory = new ReplaceableThemeFactory();
            var theme3 = replaceableFactory.CreateTheme(false);
            Console.WriteLine(theme3.Value.BackgroundColor);


            replaceableFactory.ReplaceTheme(false);
            Console.WriteLine(factory.Info());
        }
    }
}
