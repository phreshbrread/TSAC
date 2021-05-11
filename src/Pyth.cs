using System;

namespace TSAC
{
    class Pyth //2D Operation
    {
        Program program = new Program();

        public void Main(int shape)
        {
            switch (shape)
            {
                case 3:
                    Triangle();
                    break;
                default:
                    program.OptionUnavailable(true);
                    break;
            }
        }

        void Triangle()
        {
            Console.WriteLine("Input ? for the value you are trying to calculate.");
            Console.WriteLine();

            Console.Write("Side a: ");
            string input1 = Console.ReadLine();
            Console.Write("Side b: ");
            string input2 = Console.ReadLine();
            Console.Write("Hypotenuse: ");
            string input3 = Console.ReadLine();

            Double.TryParse(input1, out double a);
            Double.TryParse(input2, out double b);
            Double.TryParse(input3, out double c);

            Console.WriteLine();

            if (input1 == "?")
            {
                a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));

                Console.WriteLine("\x221A" + "(" + c + "\xB2" + " - " + b + "\xB2" + ")");
                Console.WriteLine("Side a = " + a);
            } else if (input2 == "?")
            {
                b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));

                Console.WriteLine("\x221A" + "(" + c + "\xB2" + " - " + a + "\xB2" + ")");
                Console.WriteLine("Side b = " + b);
            } else if (input3 == "?")
            {
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                Console.WriteLine("\x221A" + "(" + a + "\xB2" + " + " + b + "\xB2" + ")");
                Console.WriteLine("Hypotenuse = " + c);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please input one ? to calculate");
            }

            Exit();
        }

        void Exit()
        {
            Console.ReadKey();
            program.Start();
        }
    }
}