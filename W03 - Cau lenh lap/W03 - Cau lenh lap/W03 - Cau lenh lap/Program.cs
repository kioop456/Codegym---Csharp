﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03___Cau_lenh_lap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;


            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle");
                        Console.WriteLine("*****");
                        Console.WriteLine(" ***");
                        Console.WriteLine("  *");
                        break;
                    case 2:
                        Console.WriteLine("Draw the square");
                        Console.WriteLine("****");
                        Console.WriteLine("****");
                        Console.WriteLine("****");
                        Console.WriteLine("****");
                        break;
                    case 3:
                        Console.WriteLine("Draw the rectangle");
                        Console.WriteLine("****");
                        Console.WriteLine("****");
                        Console.WriteLine("****");
                        break;
                    case 0:
                        Environment.ExitCode = 0;
                        break;
                    default:
                        Console.WriteLine("No choice");
                        break;
                }
            }

            Console.ReadKey();

        }
    }
}
