using StepWiseBuilder.Enums;
using StepWiseBuilder.Interfaces;

namespace StepWiseBuilder
{
    public class CarBuilder
    {
        private class Implementation : IBuildCar, ISpecifyWheelSize, ISpecifyCarType
        {
            private Car car = new();
            public Car Build() => car;

            public ISpecifyWheelSize WithType(CarType type)
            {
                car.Type = type;
                return this;
            }

            public IBuildCar WithWheelSize(int size)
            {
                switch (size)
                {
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                        car.WheelSize = size;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Wheel size must be 17, 18, 19, or 20");
                }
                car.WheelSize = size;
                return this;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Implementation();
        }
    }
}
