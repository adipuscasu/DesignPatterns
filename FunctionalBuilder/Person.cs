namespace FunctionalBuilder
{
    public class Person
    {
        public string Name, Position;

        override public string ToString() => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}
