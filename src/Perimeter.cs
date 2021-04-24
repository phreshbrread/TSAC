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
                    program.OptionUnavailable();
                    break;
            }
        }

        #region Shapes
        void Square()
        {
            Console.Write("Side Length: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double squarePerimeter = side * 4;

            Console.WriteLine(side + " x 4");
            Console.WriteLine("Square Perimeter = " + squarePerimeter);

            Exit();
        }

        void Rectangle()
        {
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double rectPerimeter = (width + height) * 2;

            Console.WriteLine("(" + width + " + " + height + ")" + " x 2");
            Console.WriteLine("Rectangle Perimeter = " + rectPerimeter);

            Exit();
        }

        void Triangle()
        {
            Console.Write("Side A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double triPerimeter = a + b + c;

            Console.WriteLine(a + " + " + b + " + " + c);
            Console.WriteLine("Triangle Perimeter = " + triPerimeter);

            Exit();
        }

        void Circle()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circleCircumference = 2 * Math.PI * radius;

            Console.WriteLine("2 x " + "\x03C0" + " x " + radius);
            Console.WriteLine("Circle Circumference = " + circleCircumference);

            Exit();
        }

        void CircleSector()
        {
            Console.Write("Internal Angle: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double sectorCircumference = ((angle / 360) * 2 * Math.PI * radius) + 2 * radius;

            // TODO Print in readble form
            Console.WriteLine("((angle / 360) * 2 * Math.PI * radius) + 2 * radius");
            Console.WriteLine("Sector Circumference = " + sectorCircumference);

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