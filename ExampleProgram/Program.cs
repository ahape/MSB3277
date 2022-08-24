namespace ExampleProgram
{
    static class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Direct dependency on SharedDependency version " + new SharedDependency.SharedThing().Version);
            System.Console.WriteLine(new LibraryA.Class1().DependsOn);
            System.Console.WriteLine(new LibraryB.Class1().DependsOn);
            System.Console.ReadLine();
        }
    }
}
