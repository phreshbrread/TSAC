using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TSAC;
using TSAC.src;

namespace TSAC
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            Console.Clear();

            Cylinder cylinder = new Cylinder();
            Cube cube = new Cube();
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Which TSA to calculate?");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Cylinder");

            var input = Console.ReadLine();
            if (input == "1")
            {
                cube.Main();
            }
            else if (input == "2")
            {
                rectangle.Main();
            }
            else if (input == "3")
            {
                cylinder.Main();
            }
            {
                Console.WriteLine("Please select a valid option.");
                Console.ReadLine();
                Console.Clear();
                Start();
            }
        }
    }
}
