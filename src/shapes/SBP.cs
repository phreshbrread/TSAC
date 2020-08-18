using System;

namespace TSAC.src.shapes
{
    class SBP // Square Based Pyramid
    {
        public void Main()
        {
            Program program = new Program();

            Console.Write("Input Trianglular Face Height: ");
            double tfHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Base Width: ");
            double baseWidth = Convert.ToDouble(Console.ReadLine());

            double sbpTSA = (4 * (baseWidth * tfHeight) / 2) + (baseWidth * baseWidth);

            Console.WriteLine("SBP TSA = " + sbpTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}
