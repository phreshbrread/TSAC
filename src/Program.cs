﻿using System;

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
            Console.Clear();

            Cylinder cylinder = new Cylinder();
            Cube cube = new Cube();
            Rectangle rectangle = new Rectangle();
            SBP sbp = new SBP();

            Console.WriteLine("Which TSA to calculate?");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Cylinder");
            Console.WriteLine("4. Square-Based Pyramid");

            var input = Console.ReadLine();
            if (input == "1")
            {
                cube.Main();
            }
            else if (input == "2")
            {
                rectangle.Main();
            }
            else if (input == "3")
            {
                cylinder.Main();
            }
            else if (input == "4")
            {
                sbp.Main();
            }
            {
                Console.WriteLine("Please select a valid option.");
                Console.ReadLine();
                Console.Clear();
                Start();
            }
        }
    }
}
