using a_X_a_F;
using System;

internal static class ProgramHelpers
{
    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "white", 2021, 100);
        Console.WriteLine(Ford.Name);
        Console.WriteLine(Ford.Year);
        Console.WriteLine(Ford.Color);
    }
}