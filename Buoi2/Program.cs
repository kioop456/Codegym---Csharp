using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiem tra xem a co chia het cho b khong
            //int a = 100;
            //int b = 101;

            //int phandu = a % b;

            // có thể đặt nhiều điều kiện trong if
            // vd: và: if( dk1 && dk2 &&...)
            // vd: hoặc: if( dk1 || dk2 ||...)

            //if(phandu == 0)
            //{
            //console.writeline("a chia het cho b");
            //}
            //else
            //{
            //console.writeline("a khong chia het cho b");
            //}

            //int a = 1;
            //int b = 3;
            //int c= 3;
            //float x;

            //if(a == 0)
            //{
            //    if(c != b)
            //    {
            //        console.writeline("khong tim duoc x");
            //    }
            //    if(c == b)
            //    {
            //        console.writeline("vo so x");
            //    }
            //}
            //else
            //{
            //        x = (float)(c - b) / a;
            //        console.writeline("x = " +x);
            //}
            int a; int b; int c;

            Console.Write("Nhap a: ");
            string aString = Console.ReadLine();
            a = int.Parse(aString);

            Console.Write("Nhap b: ");
            string bString = Console.ReadLine();
            b = int.Parse(bString);

            Console.Write("Nhap c: ");
            string cString = Console.ReadLine();
            c = int.Parse(cString);

            Console.WriteLine("Giai phuong trinh");
            Console.WriteLine(a + b + c);

            Console.ReadKey();


        }
    }
}
