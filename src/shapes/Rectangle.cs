using System;

namespace TSAC.src
{
    class Rectangle
    {
        public void Main()
        {
            Program program = new Program();

            Console.Write("Input Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Depth: ");
            double depth = Convert.ToDouble(Console.ReadLine());

            double rectangleTSA = (2 * width * height) + (2 * height * depth) + (2 * width * depth);

            Console.WriteLine("Rectangle TSA = " + rectangleTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}
