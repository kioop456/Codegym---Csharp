﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02___Cau_lenh_dieu_kien
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constant:");

            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double solution = -b / a;
                Console.WriteLine("The solution is: {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("The solution is all x!");
                }
                else
                {
                    Console.WriteLine("Nod solution!");
                }
            }
            
            Console.ReadKey();

        }
    }
}
