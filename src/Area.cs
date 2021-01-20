using System;

namespace TSAC
{
    class Area
    {
        public void Main(int shape)
        {
            Program program = new Program();

            switch (shape)
            {
                case 1:
                    Square();
                    break;
                case 2:
                    Rectangle();
                    break;
                case 3:
                    Triangle();
                    break;
                case 4:
                    Circle();
                    break;
                case 5:
                    CircleSector();
                    break;
                default:
                    program.OptionUnavailable();
                    break;
            }
        }

        #region Shapes
        void Square()
        {
            Console.Write("Side Length: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double squareArea = Math.Pow(side, 2);

            Console.WriteLine(side + "\xB2");
            Console.WriteLine("Square Area = " + squareArea);

            Exit();
        }

        void Rectangle()
        {
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double rectArea = width * height;

            Console.WriteLine(width + " x " + height);
            Console.WriteLine("Rectangle Area = " + rectArea);

            Exit();
        }

        void Triangle()
        {
            Console.Write("Base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double triArea = (b * h) / 2;

            Console.WriteLine();
            Console.WriteLine("Triangle Area = " + triArea);

            Exit();
        }

        void Circle()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circleArea = 2 * Math.PI * radius;

            Console.WriteLine("2 x Pi x " + radius);
            Console.WriteLine("Circle Area = " + circleArea);

            Exit();
        }

        void CircleSector()
        {
            Console.Write("Internal Angle: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double sectorArea = ((angle / 360) * 2 * Math.PI * radius) + 2 * radius;

            Console.WriteLine("");
            Console.WriteLine("Sector Area = " + sectorArea);

            Exit();
        }

        void Exit()
        {
            Program program = new Program();

            Console.ReadKey();
            program.Start();
        }
        #endregion
    }
}