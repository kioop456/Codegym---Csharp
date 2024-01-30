using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02___Thuc_hanh__Tinh_so_can_nang_cua_co_the
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter height: ");
            double height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight: ");
            double weight = float.Parse(Console.ReadLine());

            double BMI = weight / Math.Pow(height, 2);
            BMI = Math.Round(BMI, 1);

            Console.WriteLine("BMI" + BMI);

            if (BMI < 18)
            {
                Console.WriteLine("Underweight");
            }
            else if(BMI < 25.0)
            {
                Console.WriteLine("Normal");
            }
            else if (BMI < 30.0)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

            Console.ReadKey();
        }
    }
}
