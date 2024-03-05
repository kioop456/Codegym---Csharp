using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04____Bai_tap__Them_phan_tu_vao_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            // Nhập giá trị cho mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap gia tri cho phan tu thu {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Nhap gia tri X can chen: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhap vi tri index: ");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= n)
            {
                Console.WriteLine("Khong the chen vao trong mang.");
            }
            else
            {
                // Dịch chuyển các phần tử để tạo chỗ trống cho X
                for (int i = n - 1; i > index; i--)
                {
                    array[i] = array[i - 1];
                }

                // Chèn X vào vị trí index
                array[index] = x;

                // In ra mảng sau khi chèn
                Console.WriteLine("Mang sau khi chen:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }

                Console.ReadKey();
        }

    }
}
