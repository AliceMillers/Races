using System;
using System.Threading.Tasks;

namespace Races
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car("Mustang");
            Car.Go(3);
            Task.Delay(5000).Wait();
            Console.WriteLine(Car.Distance());
            Console.WriteLine(Car.model);
        }
    }
}
