using StepWiseBuilder.Enums;

namespace StepWiseBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = CarBuilder.Create()
                .WithType(CarType.Sedan)
                .WithWheelSize(18)
                .Build();
            Console.WriteLine(car);
        }
    }
}
