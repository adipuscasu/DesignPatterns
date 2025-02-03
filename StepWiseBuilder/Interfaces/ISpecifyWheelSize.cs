using System.ComponentModel;

namespace StepWiseBuilder.Interfaces
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheelSize(int size);
    }
}