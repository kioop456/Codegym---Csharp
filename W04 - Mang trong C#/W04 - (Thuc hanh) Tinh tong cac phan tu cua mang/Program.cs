using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04____Thuc_hanh__Tinh_tong_cac_phan_tu_cua_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            int total = 0;
            for(int i = 0; i < numbers.Length; i++ )
            {
                total = total + numbers[i];
            }
            Console.WriteLine("the total is: " + total);


            Console.ReadKey();
        }
    }
}
