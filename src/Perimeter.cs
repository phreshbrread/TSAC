using System;

namespace TSAC
{
    class Perimeter //2D Operation
    {
        Program program = new Program();

        public void Main(int shape)
        {
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

        void Square()
        {
            Console.Write("Side Length: ");
            Double.TryParse(Console.ReadLine(), out double side);

            double squarePerimeter = side * 4;

            Console.WriteLine(side + " * 4");

            program.Restart(squarePerimeter);
        }

        void Rectangle()
        {
            Console.Write("Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double rectPerimeter = (width + height) * 2;

            Console.WriteLine("(" + width + " + " + height + ")" + " * 2");

            program.Restart(rectPerimeter);
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

            program.Restart(triPerimeter);
        }

        void Circle()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double circleCircumference = 2 * Math.PI * radius;

            Console.WriteLine("2 * " + "\x03C0" + " * " + radius);

            program.Restart(circleCircumference);
        }

        void CircleSector()
        {
            Console.Write("Internal Angle: ");
            Double.TryParse(Console.ReadLine(), out double angle);
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double sectorCircumference = ((angle / 360) * 2 * Math.PI * radius) + 2 * radius;

            Console.WriteLine("((" + angle + " / 360) * 2 * " + "\x03C0" + " * " + radius + ") + 2 * " + radius);

            program.Restart(sectorCircumference);
        }
    }
}