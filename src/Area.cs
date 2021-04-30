using System;

namespace TSAC
{
    class Area //2D Operation
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
                    program.OptionUnavailable(true);
                    break;
            }
        }

        #region Shapes
        void Square()
        {
            Console.Write("Side Length: ");
            Double.TryParse(Console.ReadLine(), out double side);

            double squareArea = Math.Pow(side, 2);

            Console.WriteLine(side + "\xB2");
            Console.WriteLine("Square Area = " + squareArea);

            Exit();
        }

        void Rectangle()
        {
            Console.Write("Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double rectArea = width * height;

            Console.WriteLine(width + " * " + height);
            Console.WriteLine("Rectangle Area = " + rectArea);

            Exit();
        }

        void Triangle()
        {
            Console.Write("Base: ");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double h);

            double triArea = (b * h) / 2;

            // TODO write in readable form
            Console.WriteLine("(" + b + " * " + h + ") / 2");
            Console.WriteLine("Triangle Area = " + triArea);

            Exit();
        }

        void Circle()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("\x03C0" + " * " + radius + "\xB2");
            Console.WriteLine("Circle Area = " + circleArea);

            Exit();
        }

        void CircleSector()
        {
            // V = ((internal angle / 360) * 2 * Math.PI * radius) + 2 * radius

            Console.Write("Internal Angle: ");
            Double.TryParse(Console.ReadLine(), out double angle);
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double sectorArea = ((angle / 360) * 2 * Math.PI * radius) + 2 * radius;

            Console.WriteLine("((" + angle + " / 360) * 2 * " + "\x03C0" + " * " + radius + ") + 2 * " + radius);
            Console.WriteLine("Sector Area = " + sectorArea);

            Exit();
        }
        #endregion

        void Exit()
        {
            Program program = new Program();

            Console.ReadKey();
            program.Start();
        }
    }
}