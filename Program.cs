using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_X_a_F
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120, "electric");
            Car Volvo = new Car("XC-90");            
            Ford.FullThrottle();
            Ford.honk();
            Console.WriteLine(Ford.Name);
            Console.WriteLine(Ford.Year);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.engine_type);
            Opel.FullThrottle();
            Opel.honk();
            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Opel.Color);

            Console.WriteLine("Enter Volvo's age:");
            try
            {
                Volvo.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volvo age is: " + Volvo.Year);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
