using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04____Bai_tap__Tim_phan_tu_lon_nhat_trong_mang_2_chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tao kich thuoc ma tran
            int n; int m;
            do
            {
                Console.Write("Vui long nhap row: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            do
            {
                Console.Write("Vui long nhap collumn: ");
                m = int.Parse(Console.ReadLine());
            } while (m < 0);

            double[,] matrix = new double[n,m] ;

            // Them gia tri cho ma tran
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("Nhap phan tu [{0},{1}]: ", i,j);
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
            }

            //Tim gia tri lon nhat
            double maxValue = matrix[0,0];
            int maxN = 0;
            int maxM = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j < m; j++)
                {
                    if (matrix[i,j] > maxValue)
                    {
                        maxValue = matrix[i,j];
                        maxN = i; maxM = j;
                    }
                }

            }
            Console.WriteLine($"Gia tri lon nhat la: {maxValue}. ");
            Console.WriteLine($"Nam tai vi tri [{maxN}, {maxM}]. ");

            Console.ReadKey();
        }
    }
}
