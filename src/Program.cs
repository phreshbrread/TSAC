using System;

namespace TSAC
{
    class Program
    {
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

            int num1 = 16;
            string[] shapes = new string[num1];

            // 2D Shapes
            shapes[0] = null;
            shapes[1] = "Square";
            shapes[2] = "Rectangle";
            shapes[3] = "Triangle";
            shapes[4] = "Circle";
            shapes[5] = "Circle Sector";
            // 3D Shapes
            shapes[6] = "Cube";
            shapes[7] = "Rectangular Prism";
            shapes[8] = "Triangular Prism";
            shapes[9] = "Square-Based Pyramid";
            shapes[10] = "Rectangle-Based Pyramid";
            shapes[11] = "Cylinder";
            shapes[12] = "Cylinder Sector";
            shapes[13] = "Sphere";
            shapes[14] = "Hemisphere";
            shapes[15] = "Cone";

            for (int i = 1; i < num1; i++) // Output shapes menu
            {
                Console.WriteLine((i + ". ") + shapes[i]);
            }

            int shape = 0;
            try
            {
                shape = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                OptionUnavailable(false);
            }
            catch (FormatException)
            {
                OptionUnavailable(false);
            }


            if (shape < num1 && shape > 0)
            {
                // Continue
            }
            else
            {
                OptionUnavailable(false);
            }
            #endregion

            Console.WriteLine();

            #region Operations Menu
            Console.WriteLine("Select what to calculate");
            Console.WriteLine();

            int num2 = 6;
            string[] calculations = new string[num2];

            calculations[0] = null;
            calculations[1] = "Perimeter";
            calculations[2] = "Area";
            calculations[3] = "Volume";
            calculations[4] = "Total Surface Area";
            calculations[5] = "Pythagoras' Theorem";

            for (int i = 1; i < num2; i++) // Output calculations menu
            {
                Console.WriteLine((i + ". ") + calculations[i]);
            }

            int calculate = 0;
            try
            {
                calculate = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                OptionUnavailable(false);
            }
            catch (FormatException)
            {
                OptionUnavailable(false);
            }

            if (calculate < num2 && calculate > 0)
            {
                // Continue
            }
            else
            {
                OptionUnavailable(false);
            }
            #endregion

            Console.Clear();
            Console.WriteLine(calculations[calculate] + ": " + shapes[shape]);
            Console.WriteLine();

            switch (calculate)
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
            
            Console.ReadLine();
            Main();
        }
    }
}