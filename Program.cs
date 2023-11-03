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
            Car Ford = new Car();
            Ford.name = "Mustang";
            Ford.year = 2021;
            Ford.color = "white";
            Ford.maxSpeed = 100;
            Ford.FullThrottle();
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);

            Car Opel = new Car();
            Opel.name = "Astra";
            Opel.year = 2005;
            Opel.color = "red";
            Opel.maxSpeed = 170;
            Opel.FullThrottle();
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.color);

            Car Audi = new Car();
            Audi.name = "Performance";
            Audi.year = 2019;
            Audi.color = "blue";
            Audi.maxSpeed = 300;
            Audi.FullThrottle();
            Console.WriteLine(Audi.name);
            Console.WriteLine(Audi.year);
            Console.WriteLine(Audi.color);

            Car Volvo = new Car();
            Volvo.name = "XC40 Recharge";
            Volvo.year = 2013;
            Volvo.color = "black";
            Volvo.maxSpeed = 180;
            Volvo.FullThrottle();
            Console.WriteLine(Volvo.name);
            Console.WriteLine(Volvo.year);
            Console.WriteLine(Volvo.color);

            Car Renault = new Car();
            Renault.name = "Megan";
            Renault.year = 2007;
            Renault.color = "green";
            Renault.maxSpeed = 130;
            Renault.FullThrottle();
            Console.WriteLine(Renault.name);
            Console.WriteLine(Renault.year);
            Console.WriteLine(Renault.color);
        }
    }
}
