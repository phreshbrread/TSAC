using System;

namespace TSAC
{
    class Perimeter //2D Operation
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

            double squarePerimeter = side * 4;

            Console.WriteLine(side + " * 4");
            Console.WriteLine("Square Perimeter = " + squarePerimeter);

            Exit();
        }

        void Rectangle()
        {
            Console.Write("Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double rectPerimeter = (width + height) * 2;

            Console.WriteLine("(" + width + " + " + height + ")" + " * 2");
            Console.WriteLine("Rectangle Perimeter = " + rectPerimeter);

            Exit();
        }

        void Triangle()
        {
            Console.Write("Side A: ");
            Double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Side B: ");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Side C: ");
            Double.TryParse(Console.ReadLine(), out double c);

            double triPerimeter = a + b + c;

            Console.WriteLine(a + " + " + b + " + " + c);
            Console.WriteLine("Triangle Perimeter = " + triPerimeter);

            Exit();
        }

        void Circle()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double circleCircumference = 2 * Math.PI * radius;

            Console.WriteLine("2 * " + "\x03C0" + " * " + radius);
            Console.WriteLine("Circle Circumference = " + circleCircumference);

            Exit();
        }

        void CircleSector()
        {
            Console.Write("Internal Angle: ");
            Double.TryParse(Console.ReadLine(), out double angle);
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double sectorCircumference = ((angle / 360) * 2 * Math.PI * radius) + 2 * radius;

            Console.WriteLine("((" + angle + " / 360) * 2 * " + "\x03C0" + " * " + radius + ") + 2 * " + radius);
            Console.WriteLine("Sector Circumference = " + sectorCircumference);

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