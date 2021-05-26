using System;

namespace TSAC
{
    class Area //2D Operation
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
                    program.OptionUnavailable(false);
                    break;
            }
        }

        void Square()
        {
            Console.Write("Side Length: ");
            Double.TryParse(Console.ReadLine(), out double side);

            double squareArea = Math.Pow(side, 2);

            Console.WriteLine(side + "\xB2");

            program.Restart(squareArea);
        }

        void Rectangle()
        {
            Console.Write("Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double rectArea = width * height;

            Console.WriteLine(width + " * " + height);

            program.Restart(rectArea);
        }

        void Triangle()
        {
            Console.Write("Base: ");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double h);

            double triArea = (b * h) / 2;

            Console.WriteLine("(" + b + " * " + h + ") / 2");

            program.Restart(triArea);
        }

        void Circle()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("\x03C0" + " * " + radius + "\xB2");

            program.Restart(circleArea);
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

            program.Restart(sectorArea);
        }
    }
}