using System;

namespace TSAC
{
    class Volume //3D Operation
    {
        public void Main(int shape)
        {
            Program program = new Program();

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
                    program.OptionUnavailable();
                    break;
            }
        }

        #region Objects
        void Cube()
        {
            Console.Write("Side Length: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double cubeVolume = Math.Pow(sideLength, 3);

            Console.WriteLine(sideLength + ".cubed");
            Console.WriteLine("Cube Volume = " + cubeVolume);

            Exit();
        }

        void RectPrism()
        {
            Console.Write("Depth: ");
            double depth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double rectVolume = depth * width * height;

            Console.WriteLine(depth + " x " + width + " x " + height);
            Console.WriteLine("Rectanglular Prism Volume = " + rectVolume);

            Exit();
        }

        void TriPrism()
        {
            Console.Write("Base: ");
            double baseL = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            double rectVolume = (baseL * height * length) / 2;

            Console.WriteLine("(" + baseL + " x " + height + " x " + length + ") / 2");
            Console.WriteLine("Triangular Prism Volume = " + rectVolume);

            Exit();
        }

        void SBP() //Square-Based Pyramid
        {
            Console.Write("Base Edge: ");
            double baseEdge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double sbpVolume = Math.Pow(baseEdge, 2) * (height / 3);

            Console.WriteLine(baseEdge + "\xB2" + " x (" + height + " / 3)");
            Console.WriteLine("SBP Volume = " + sbpVolume);

            Exit();
        }

        void RBP() //Rectangle-Based Pyramid
        {
            Console.Write("Base Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double rbpVolume = (length * width * height) / 3;

            Console.WriteLine("(" + length + " * " + width + " * " + height + ") / 3");
            Console.WriteLine("RBP Volume = " + rbpVolume);

            Exit();
        }

        void Cylinder()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cylinderVolume = Math.PI * (radius * radius) * height;

            Console.WriteLine("\x03C0" + " x " + radius + " x " + radius + " x " + height);
            Console.WriteLine("Cylinder Volume = " + cylinderVolume);

            Exit();
        }

        void CylinderSector()
        {
            Console.Write("Internal Angle: ");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double sectVolume = (angle / 360) * Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine("(" + angle + " / 360) x " + "\x03C0" + " x " + radius + "\xB2" + " x " + height);
            Console.WriteLine("Cylinder Volume = " + sectVolume);

            Exit();
        }

        void Sphere()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double sphereVolume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;

            Console.WriteLine("(4 x " + "\x03C0" + " x " + radius + ".cubed" + ") / 3");
            Console.WriteLine("Sphere Volume = " + sphereVolume);

            Exit();
        }

        void Hemisphere()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double hemiVolume = ((4 * Math.PI * Math.Pow(radius, 3)) / 3) / 2;

            Console.WriteLine("((4 x " + "\x03C0" + " x " + radius + ".cubed" + ") / 3) / 2");
            Console.WriteLine("Sphere Volume = " + hemiVolume);

            Exit();
        }

        void Cone()
        {
            // Volume = Pi * radius.squared * (height / 3);

            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double coneVolume = Math.PI * Math.Pow(radius, 2) * (height / 3);

            Console.WriteLine("\x03C0" + " * " + radius + "\xB2" + " * " + "(" + height + " / 3)");
            Console.WriteLine("Cone Volume = " + coneVolume);
            
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