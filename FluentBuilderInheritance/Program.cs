namespace FluentBuilderInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonJobBuilder pb = new();
            pb.Called("Dmitri").WorksAsA("Quant").Build();
        }
    }
}
