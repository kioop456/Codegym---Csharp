using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04____Bai_tap___Tong_duong_cheo_cua_ma_tran_hinh_vuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tao matrix

            Console.Write("Vui long nhap row = collumn: ");
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, n];

            // Them gia tri vao matrix
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap gia tri [{i},{j}]: ");
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
            }

            // Tinh tong duong cheo chinh
            double sum = 0;
            for(int i = 0;i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if(i == j)
                    {
                        sum += matrix[i,j];
                    }
                }
            }
            Console.WriteLine($"Tong cac phan tu tren duong cheo chinh la {sum}.");
            Console.ReadKey();

        }
    }
}
