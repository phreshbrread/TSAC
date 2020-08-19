using System;

namespace TSAC
{
    class Cylinder
    {
        public void Main()
        {
            Program program = new Program();

            Console.Clear();
            Console.WriteLine("Cylinder");
            Console.WriteLine("");

            Console.Write("Input Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cylinderTSA = 2 * Math.PI * radius * (height + radius);

            Console.WriteLine("2 x Pi x " + radius + " x " + "(" + height + " x " + radius + ")");
            Console.WriteLine("Cylinder TSA = " + cylinderTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}