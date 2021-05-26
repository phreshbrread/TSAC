using System;

namespace TSAC
{
    class Program
    {
        public int whatToCalculate;
        public int shape;

        public string[] shapeMenu = {null,"Square","Rectangle","Triangle","Circle","Circle Sector",
                "Cube", "Rectangular Prism", "Triangular Prism", "Square-Based Pyramid",
                "Rectangle-Based Pyramid", "Cylinder", "Cylinder Sector", "Sphere", "Hemisphere", "Cone"};

        public string[] calculationMenu = {null, "Perimeter", "Area", "Volume",
                "Total Surface Area", "Pythagoras' Theorem"};

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


            for (int i = 1; i < shapeMenu.Length; i++) // Output shapes menu
            {
                Console.WriteLine((i + ". ") + shapeMenu[i]);
            }
            #endregion

            Int32.TryParse(Console.ReadLine(), out shape);
            if (shape > shapeMenu.Length || shape <= 0)
            {
                OptionUnavailable(true);
            }

            Console.WriteLine();

            #region Operations Menu
            Console.WriteLine("Select what to calculate");
            Console.WriteLine();

            int e = 5;
            if (shape == 3)
            {
                e = 6;
            }

            for (int i = 1; i < e; i++) // Output calculations menu
            {
                Console.WriteLine((i + ". ") + calculationMenu[i]);
            }
            #endregion

            Int32.TryParse(Console.ReadLine(), out whatToCalculate);
            if (whatToCalculate > calculationMenu.Length || whatToCalculate <= 0 || (shape != 3 && whatToCalculate == 5))
            {
                OptionUnavailable(true);
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
                default:
                    OptionUnavailable(true);
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

            Restart(0, false); // Restart without printing a result
        }

        public void Restart(double result, bool i = true)
        {
            if (i == true)
            {
                Console.WriteLine(shapeAndCalc + " = " + result);
            }

            Console.ReadLine();
            Start();
        }
    }
}