namespace StepWiseBuilder
{
    public class Car
    {
        public Enums.CarType Type { get; set; }
        public int WheelSize { get; set; }

        public override string ToString()
        {
            return $"Car Type: {Type}, Wheel Size: {WheelSize}";
        }
    }
}
