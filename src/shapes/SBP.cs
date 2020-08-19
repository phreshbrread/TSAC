using System;

namespace TSAC
{
    class SBP // Square Based Pyramid
    {
        public void Main()
        {
            Program program = new Program();

            Console.Clear();
            Console.WriteLine("Square-Based Pyramid");
            Console.WriteLine("");

            Console.Write("Input Trianglular Face Height: ");
            double tfHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Base Width: ");
            double baseWidth = Convert.ToDouble(Console.ReadLine());

            double sbpTSA = (4 * (baseWidth * tfHeight) / 2) + (baseWidth * baseWidth);

            Console.WriteLine("(4 x (" + baseWidth + " x " + tfHeight + ") / 2)" + " + " + "(" + baseWidth + " x " + baseWidth + ")");
            Console.WriteLine("SBP TSA = " + sbpTSA);
            Console.ReadKey();

            program.Start();
        }
    }
}
