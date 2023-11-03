using a_X_a_F;
using System;

internal static class ProgramHelpers
{
    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.name = "Mustang";
        Ford.year = 2021;
        Ford.color = "white";
        Ford.maxSpeed = 100;
        Ford.FullThrottle();
        Console.WriteLine(Ford.name);
        Console.WriteLine(Ford.year);
        Console.WriteLine(Ford.color);
    }
}