using ShipYard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shps
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ships = new Construction();
            var ship = ships.GetClipper();
            Console.WriteLine("Press Any Key to get a ship :)");
            Console.ReadKey();
            Console.WriteLine(ship);
            Console.WriteLine("Happy Sailing!");
            Console.ReadKey();
        }
    }
}
