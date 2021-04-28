using System;

namespace TSAC
{
    class TSA //3D Operation
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
            Double.TryParse(Console.ReadLine(), out double sideLength);

            double cubeTSA = 6 * Math.Pow(sideLength, 2);

            Console.WriteLine("6 x " + sideLength + "\xB2");
            Console.WriteLine("Cube TSA = " + cubeTSA);

            Exit();
        }

        void RectPrism()
        {
            Console.Write("Width: ");
            Double.TryParse(Console.ReadLine(), out double width);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);
            Console.Write("Depth: ");
            Double.TryParse(Console.ReadLine(), out double depth);

            double rectTSA = (2 * width * height) + (2 * height * depth) + (2 * width * depth);

            Console.WriteLine("(2 x " + width + " x " + height + ")" + " + " + "(2 x " + height + " x " + depth + ")" + " + " + "(2 x " + width + " x " + depth + ")");
            Console.WriteLine("Rectangle TSA = " + rectTSA);

            Exit();
        }

        void TriPrism()
        {
            // Not sure if this is actually correct

            // TSA = bh + 2ls + lb

            Console.WriteLine("Not sure if this actually gets the correct answer yet.");
            Console.WriteLine();

            Console.Write("Triangular Face Base: ");
            Double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Triangular Face Height: ");
            Double.TryParse(Console.ReadLine(), out double h);
            Console.Write("Object Length / Depth: ");
            Double.TryParse(Console.ReadLine(), out double l);
            Console.Write("Triangular Face Slant: ");
            Double.TryParse(Console.ReadLine(), out double s);

            double triTSA = (b * h) + (2 * l * s) + (l * b);

            Console.WriteLine("(" + b + " * "  +  h + ") + (2" + " * " + l + " * " + s + ") + (" + l + " * " + b + ")");
            Console.WriteLine("Triangular Prism TSA = " + triTSA);

            Exit();
        }

        void SBP() //Square-Based Pyramid
        {
            Console.Write("Trianglular Face Height: ");
            Double.TryParse(Console.ReadLine(), out double tfHeight);
            Console.Write("Base Width: ");
            Double.TryParse(Console.ReadLine(), out double baseWidth);

            double sbpTSA = (4 * (baseWidth * tfHeight) / 2) + Math.Pow(baseWidth, 2);

            Console.WriteLine("(4 x (" + baseWidth + " x " + tfHeight + ") / 2)" + " + " + "(" + baseWidth + " x " + baseWidth + ")");
            Console.WriteLine("SBP TSA = " + sbpTSA);

            Exit();
        }

        void RBP() //Rectangle-Based Pyramid
        {
            Console.Write("Rectangular Base: ");
            Double.TryParse(Console.ReadLine(), out double lw);
            Console.Write("Front / Back Triangle Areas: ");
            Double.TryParse(Console.ReadLine(), out double lh);
            Console.Write("Side Traingle Areas: ");
            Double.TryParse(Console.ReadLine(), out double wh);

            double rbpTSA = lw + lh + wh;

            Console.WriteLine(lw + " + " + lh + " + " + wh);
            Console.WriteLine("RBP TSA = " + rbpTSA);

            Exit();
        }

        void Cylinder()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double cylinderTSA = 2 * Math.PI * radius * (height + radius);

            Console.WriteLine("2 x " + "\x03C0" + " x " + radius + " x " + "(" + height + " x " + radius + ")");
            Console.WriteLine("Cylinder TSA = " + cylinderTSA);

            Exit();
        }

        void CylinderSector()
        {
            Console.Write("Internal Angle: ");
            Double.TryParse(Console.ReadLine(), out double angle);
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);
            Console.Write("Height: ");
            Double.TryParse(Console.ReadLine(), out double height);

            double diameter = radius * 2;
            double sectTSA = (2 * (angle/360) * Math.PI * Math.Pow(radius, 2)) + ((angle/360) * Math.PI * diameter * height) + (2 * height * radius);

            Console.WriteLine("(2 x (" + angle + " / 360) x " + "\x03C0" + " x " + radius + "²)" + " + " + "(" + angle + " / 360) x " + "\x03C0" + " x " + diameter + " x " + height + ")" + " + " + "(2 x " + height + " x " + radius + ")");
            Console.WriteLine("Sector TSA = " + sectTSA);

            Exit();
        }

        void Sphere()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double sphereTSA = 4 * Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("4 x " + "\x03C0" + " x " + radius + "\xB2");
            Console.WriteLine("Sphere Volume = " + sphereTSA);

            Exit();
        }

        void Hemisphere()
        {
            Console.Write("Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);

            double hemiTSA = (4 * Math.PI * Math.Pow(radius, 2)) / 2;

            Console.WriteLine("(4 x " + "\x03C0" + " x " + radius + "\xB2) / 2");
            Console.WriteLine("Sphere Volume = " + hemiTSA);

            Exit();
        }

        void Cone()
        {
            Console.Write("Base Radius: ");
            Double.TryParse(Console.ReadLine(), out double radius);
            Console.Write("Slant Height: ");
            Double.TryParse(Console.ReadLine(), out double slant);

            double coneTSA = (Math.PI * (Math.Pow(radius, 2))) + (Math.PI * radius * slant);

            Console.WriteLine("(" + "\x03C0" + " * (" + radius + "\xB2" + ")) + " + "\x03C0" + " * " + radius + " * " + slant);
            Console.WriteLine("Cone TSA = " + coneTSA);

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