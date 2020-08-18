using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSAC
{
    class Cylinder
    {
        public void Main()
        {
            Program program = new Program();

            Console.Write("Input Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cylinderTSA = (2 * Math.PI + radius) + (2 * Math.PI * radius * height);

            Console.WriteLine("Cylinder TSA = " + cylinderTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}