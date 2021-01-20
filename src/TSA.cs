using System;

namespace TSAC
{
    class TSA
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
                /*case 8:
                    TriPrism();
                    break;*/
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

            double cubeTSA = 6 * Math.Pow(sideLength, 2);

            Console.WriteLine("6 x " + sideLength + "\xB2");
            Console.WriteLine("Cube TSA = " + cubeTSA);

            Exit();
        }

        void RectPrism()
        {
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Depth: ");
            double depth = Convert.ToDouble(Console.ReadLine());

            double rectTSA = (2 * width * height) + (2 * height * depth) + (2 * width * depth);

            Console.WriteLine("(2 x " + width + " x " + height + ")" + " + " + "(2 x " + height + " x " + depth + ")" + " + " + "(2 x " + width + " x " + depth + ")");
            Console.WriteLine("Rectangle TSA = " + rectTSA);

            Exit();
        }

        void TriPrism()
        {
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Depth: ");
            double depth = Convert.ToDouble(Console.ReadLine());

            double triTSA = (2 * width * height) + (2 * height * depth) + (2 * width * depth);

            Console.WriteLine("(2 x " + width + " x " + height + ")" + " + " + "(2 x " + height + " x " + depth + ")" + " + " + "(2 x " + width + " x " + depth + ")");
            Console.WriteLine("Rectangle TSA = " + triTSA);

            Exit();
        }

        void SBP()
        {
            Console.Write("Trianglular Face Height: ");
            double tfHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Base Width: ");
            double baseWidth = Convert.ToDouble(Console.ReadLine());

            double sbpTSA = (4 * (baseWidth * tfHeight) / 2) + Math.Pow(baseWidth, 2);

            Console.WriteLine("(4 x (" + baseWidth + " x " + tfHeight + ") / 2)" + " + " + "(" + baseWidth + " x " + baseWidth + ")");
            Console.WriteLine("SBP TSA = " + sbpTSA);

            Exit();
        }

        void Cylinder()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cylinderTSA = 2 * Math.PI * radius * (height + radius);

            Console.WriteLine("2 x Pi x " + radius + " x " + "(" + height + " x " + radius + ")");
            Console.WriteLine("Cylinder TSA = " + cylinderTSA);

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

            double diameter = radius * 2;
            double sectTSA = (2 * (angle/360) * Math.PI * Math.Pow(radius, 2)) + ((angle/360) * Math.PI * diameter * height) + (2 * height * radius);

            Console.WriteLine("(2 x (" + angle + " / 360) x Pi x " + radius + "²)" + " + " + "(" + angle + " / 360) x Pi x " + diameter + " x " + height + ")" + " + " + "(2 x " + height + " x " + radius + ")");
            Console.WriteLine("Sector TSA = " + sectTSA);

            Exit();
        }

        void Sphere()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double sphereTSA = 4 * Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("4 x Pi x " + radius + "\xB2");
            Console.WriteLine("Sphere Volume = " + sphereTSA);

            Exit();
        }

        void Hemisphere()
        {
            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double hemiTSA = (4 * Math.PI * Math.Pow(radius, 2)) / 2;

            Console.WriteLine("(4 x Pi x " + radius + "\xB2) / 2");
            Console.WriteLine("Sphere Volume = " + hemiTSA);

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