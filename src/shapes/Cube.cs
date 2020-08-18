using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSAC.src
{
    class Cube
    {
        public void Main()
        {
            Program program = new Program();

            Console.Write("Input Side Length: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double cubeTSA = 6 * Math.Pow(sideLength, 2);

            Console.WriteLine("Cube TSA = " + cubeTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}
