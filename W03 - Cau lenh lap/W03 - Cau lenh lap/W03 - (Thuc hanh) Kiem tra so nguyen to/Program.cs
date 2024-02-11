using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03____Thuc_hanh__Kiem_tra_so_nguyen_to
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if(number < 2)
            {
                Console.WriteLine(number + " is not a prime");
            }
            else
            {
                int i = 2;
                bool check = true;
                while(i <= Math.Sqrt(number))
                {
                    if(number == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if(check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else 
                {
                    Console.WriteLine(number + " is not a prime"); 
                }
            }

            Console.ReadKey();

        }
    }
}
