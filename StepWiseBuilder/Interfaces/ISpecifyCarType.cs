namespace StepWiseBuilder.Interfaces
{
    public interface ISpecifyCarType
    {
        ISpecifyWheelSize WithType(Enums.CarType type);
    }
}
