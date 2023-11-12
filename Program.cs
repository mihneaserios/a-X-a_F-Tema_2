using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_X_a_F
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable IDE0017 // Simplify object initialization
            Car Ford = new Car();
#pragma warning restore IDE0017 // Simplify object initialization
            Ford.name = "Mustang";
            Ford.year = 2021;
            Ford.color = "white";
            Ford.maxSpeed = 100;
            Ford.FullThrottle();
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);

#pragma warning disable IDE0017 // Simplify object initialization
            Car Opel = new Car();
#pragma warning restore IDE0017 // Simplify object initialization
            Opel.name = "Astra";
            Opel.year = 2005;
            Opel.color = "red";
            Opel.maxSpeed = 170;
            Opel.FullThrottle();
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);

#pragma warning disable IDE0017 // Simplify object initialization
            Car Volvo = new Car();
#pragma warning restore IDE0017 // Simplify object initialization
            Volvo.name = "XC40 Recharge";
            Volvo.FullThrottle();
            Console.WriteLine(Volvo.name);
            Console.WriteLine(Volvo.year);
        }
    }
}
