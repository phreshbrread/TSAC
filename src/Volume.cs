using System;

namespace TSAC
{
    class Volume
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
                    Cylinder();
                    break;
                case 11:
                    CylinderSector();
                    break;
                case 12:
                    Sphere();
                    break;
                case 13:
                    Hemisphere();
                    break;
                default:
                    program.OptionUnavailable();
                    break;
            }
        }

        #region Shapes
        void Cube()
        {
            Console.Write("Side Length: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double cubeVolume = Math.Pow(sideLength, 3);

            Console.WriteLine("Pow(" + sideLength + ", 3)");
            Console.WriteLine("Cube Volume = " + cubeVolume);

            Exit();
        }

        void RectPrism()
        {
            Console.Write("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double rectVolume = length * width * height;

            Console.WriteLine(length + " x " + width + " x " + height);
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
            Console.WriteLine("Rectanglular Prism Volume = " + rectVolume);

            Exit();
        }

        void SBP()
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

        void Cylinder()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cylinderVolume = Math.PI * (radius * radius) * height;

            Console.WriteLine("Pi x " + radius + " x " + radius + " x " + height);
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

            Console.WriteLine("(" + angle + " / 360) x Pi x Pow(" + radius + ", 2)" + " x " + height);
            Console.WriteLine("Cylinder Volume = " + sectVolume);

            Exit();
        }

        void Sphere()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double sphereVolume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;

            Console.WriteLine("(4 x Pi x Pow(" + radius + ", 3)) / 3");
            Console.WriteLine("Sphere Volume = " + sphereVolume);

            Exit();
        }

        void Hemisphere()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double hemiVolume = ((4 * Math.PI * Math.Pow(radius, 3)) / 3) / 2;

            Console.WriteLine("((4 x Pi x Pow(" + radius + ", 3)) / 3) / 2");
            Console.WriteLine("Sphere Volume = " + hemiVolume);

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