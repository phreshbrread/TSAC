using System;

namespace TSAC
{
    class Program
    {
        public int whatToCalculate;
        public int shape;

        static int shapeMenuLength = 16;
        public string[] shapeMenu = new string[shapeMenuLength];

        static int calcMenuLength = 6;
        public string[] calculationMenu = new string[calcMenuLength];

        static string shapeAndCalc = null;

        static void Main()
        {
            Program program = new Program();
            program.Start();
        }

        public void Start()
        {
            // "\xB2" is for Squared
            // "\x00B3" is meant to be for Cubed but doesn't show as superscript for some reason
            // "\x03C0" is for Pi
            // "\x221A" is for Square root

            Perimeter perimeter = new Perimeter();
            Area area = new Area();
            Volume volume = new Volume();
            TSA tsa = new TSA();
            Pyth pyth = new Pyth();

            Console.Clear();

            #region Shapes Menu
            Console.WriteLine("Select shape");
            Console.WriteLine();

            // 2D Shapes
            shapeMenu[0] = null;
            shapeMenu[1] = "Square";
            shapeMenu[2] = "Rectangle";
            shapeMenu[3] = "Triangle";
            shapeMenu[4] = "Circle";
            shapeMenu[5] = "Circle Sector";
            // 3D Shapes
            shapeMenu[6] = "Cube";
            shapeMenu[7] = "Rectangular Prism";
            shapeMenu[8] = "Triangular Prism";
            shapeMenu[9] = "Square-Based Pyramid";
            shapeMenu[10] = "Rectangle-Based Pyramid";
            shapeMenu[11] = "Cylinder";
            shapeMenu[12] = "Cylinder Sector";
            shapeMenu[13] = "Sphere";
            shapeMenu[14] = "Hemisphere";
            shapeMenu[15] = "Cone";

            for (int i = 1; i < shapeMenuLength; i++) // Output shapes menu
            {
                Console.WriteLine((i + ". ") + shapeMenu[i]);
            }
            #endregion

            Int32.TryParse(Console.ReadLine(), out shape);
            if (shape > shapeMenuLength && shape <= 0)
            {
                OptionUnavailable(false);
            }

            Console.WriteLine();

            #region Operations Menu
            Console.WriteLine("Select what to calculate");
            Console.WriteLine();

            calculationMenu[0] = null;
            calculationMenu[1] = "Perimeter";
            calculationMenu[2] = "Area";
            calculationMenu[3] = "Volume";
            calculationMenu[4] = "Total Surface Area";
            calculationMenu[5] = "Pythagoras' Theorem";


            for (int i = 1; i < calcMenuLength; i++) // Output calculations menu
            {
                Console.WriteLine((i + ". ") + calculationMenu[i]);
            }
            #endregion

            Int32.TryParse(Console.ReadLine(), out whatToCalculate);
            if (whatToCalculate > calcMenuLength && whatToCalculate <= 0)
            {
                OptionUnavailable(false);
            }

            Console.Clear();
            Console.WriteLine(calculationMenu[whatToCalculate] + ": " + shapeMenu[shape]);

            shapeAndCalc = shapeMenu[shape] + " " + calculationMenu[whatToCalculate];

            Console.WriteLine();

            switch (whatToCalculate)
            {
                case 1:
                    perimeter.Main(shape);
                    break;
                case 2:
                    area.Main(shape);
                    break;
                case 3:
                    volume.Main(shape);
                    break;
                case 4:
                    tsa.Main(shape);
                    break;
                case 5:
                    pyth.Main(shape);
                    break;
            }
        }

        public void OptionUnavailable(bool invalid)
        {
            if (invalid == true)
            {
                Console.WriteLine("Please select a valid option");
            }
            else
            {
                Console.WriteLine("Option Unavailable");
            }

            Restart(0, false); // Use this to restart without printing a result
        }

        public void Restart(double result, bool i = true)
        {
            if (i == true)
            { // TODO automate this shid
                //Console.WriteLine(result);
                Console.WriteLine(shapeAndCalc + " = " + result);
            }

            Console.ReadLine();
            Start();
        }
    }
}