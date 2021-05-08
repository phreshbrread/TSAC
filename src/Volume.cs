using System;

namespace TSAC
{
    class Volume //3D Operation
    {
        Program program = new Program();

        public void Main(int shape)
        {
            switch (shape)
            {
                case 6:
                    Cube();
                    break;
                case 7:
                    RectPrism();
                    break;
                case 8:
                    TriPrism();
                    break;
                case 9:
                    SBP();
                    break;
                case 10:
                    RBP();
                    break;
                case 11:
                    Cylinder();
                    break;
                case 12:
                    CylinderSector();
                    break;
                case 13:
                    Sphere();
                    break;
                case 14:
                    Hemisphere();
                    break;
                case 15:
                    Cone();
                    break;
                default:
                    program.OptionUnavailable(true);
                    break;
            }
        }

        void Cube()
        {
            Console.Write("Side Length: ");
            Double.TryParse(Console.ReadLine(), out double sideLength);

            double cubeVolume = Math.Pow(sideLength, 3);

            Console.WriteLine(sideLength + "^3");
            Console.WriteLine("Cube Volume = ");

            program.Restart(cubeVolume);
        }

        void RectPrism()
        {
            Console.Write("Depth: ");
            Double.TryParse(Console.ReadLine(), out double depth);
            Console.Write("Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double rectVolume = depth * width * height;

            Console.WriteLine(depth + " * " + width + " * " + height);
            Console.WriteLine("Rectanglular Prism Volume = ");

            program.Restart(rectVolume);
        }

        void TriPrism()
        {
            Console.Write("Base: ");
            Double.TryParse(Console.ReadLine(), out double baseL);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);
            Console.Write("Length: ");
            Double.TryParse(Console.ReadLine(), out double length);

            double rectVolume = (baseL * height * length) / 2;

            Console.WriteLine("(" + baseL + " * " + height + " * " + length + ") / 2");
            Console.WriteLine("Triangular Prism Volume = ");

            program.Restart(rectVolume);
        }

        void SBP() //Square-Based Pyramid
        {
            Console.Write("Base Edge: ");
            Double.TryParse(Console.ReadLine(), out double baseEdge);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double sbpVolume = Math.Pow(baseEdge, 2) * (height / 3);

            Console.WriteLine(baseEdge + "\xB2" + " * (" + height + " / 3)");
            Console.WriteLine("SBP Volume = ");

            program.Restart(sbpVolume);
        }

        void RBP() //Rectangle-Based Pyramid
        {
            Console.Write("Base Length: ");
            Double.TryParse(Console.ReadLine(), out double length);
            Console.Write("Base Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Base Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double rbpVolume = (length * width * height) / 3;

            Console.WriteLine("(" + length + " * " + width + " * " + height + ") / 3");
            Console.WriteLine("RBP Volume = ");

            program.Restart(rbpVolume);
        }

        void Cylinder()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double cylinderVolume = Math.PI * (radius * radius) * height;

            Console.WriteLine("\x03C0" + " * " + radius + " * " + radius + " * " + height);
            Console.WriteLine("Cylinder Volume = ");

            program.Restart(cylinderVolume);
        }

        void CylinderSector()
        {
            Console.Write("Internal Angle: ");
            Double.TryParse(Console.ReadLine(), out double angle);
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double sectVolume = (angle / 360) * Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine("(" + angle + " / 360) * " + "\x03C0" + " * " + radius + "\xB2" + " * " + height);
            Console.WriteLine("Cylinder Volume = ");

            program.Restart(sectVolume);
        }

        void Sphere()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double sphereVolume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;

            Console.WriteLine("(4 * " + "\x03C0" + " * " + radius + "^3" + ") / 3");
            Console.WriteLine("Sphere Volume = ");

            program.Restart(sphereVolume);
        }

        void Hemisphere()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double hemiVolume = (4 * Math.PI * Math.Pow(radius, 3) / 3) / 2;

            Console.WriteLine("((4 * " + "\x03C0" + " * " + radius + "^3" + ") / 3) / 2");
            Console.WriteLine("Sphere Volume = ");

            program.Restart(hemiVolume);
        }

        void Cone()
        {
            // Volume = Pi * radius.squared * (height / 3);

            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);
            Console.Write("Base Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double coneVolume = Math.PI * Math.Pow(radius, 2) * (height / 3);

            Console.WriteLine("\x03C0" + " * " + radius + "\xB2" + " * " + "(" + height + " / 3)");
            Console.WriteLine("Cone Volume = ");

            program.Restart(coneVolume);
        }
    }
}