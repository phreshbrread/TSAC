using System;

namespace TSAC
{
    class Cube
    {
        public void Main()
        {
            Program program = new Program();

            Console.Clear();
            Console.WriteLine("Cube");
            Console.WriteLine("");

            Console.Write("Input Side Length: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double cubeTSA = 6 * Math.Pow(sideLength, 2);

            Console.WriteLine("6 x (" + sideLength + " x " + sideLength + ")");
            Console.WriteLine("Cube TSA = " + cubeTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}