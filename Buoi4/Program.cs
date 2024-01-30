using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Bai_-4
            //Console.Write("Vui long nhap tuoi: ");
            //string tuoi = Console.ReadLine();
            //int tuoiInt = int.Parse(tuoi);

            //if (tuoiInt > 0 && tuoiInt  <= 2)
            //{
            //    Console.WriteLine("Tre so sinh");
            //}
            //else if (tuoiInt > 2 && tuoiInt <= 10)
            //{
            //    Console.WriteLine("Nhi dong");
            //}
            //else if (tuoiInt > 10 && tuoiInt <= 17)
            //{
            //    Console.WriteLine("Vi thanh nien");
            //}
            //else if(tuoiInt > 17 && tuoiInt <= 39)
            //{
            //    Console.WriteLine("Thanh nien");
            //}
            //else if(tuoiInt > 39 && tuoiInt <= 50)
            //{
            //    Console.WriteLine("Trung nien");
            //}
            //else
            //{
            //    Console.WriteLine("Cao nien");
            //}

            #endregion

            #region Bai_-3

            //Console.Write("Vui long nhap nam san xuat: ");
            //int nam = int.Parse(Console.ReadLine());

            //if (nam >= 15)
            //{
            //    Console.WriteLine("thay the");
            //}
            //else if (nam >= 10 && nam < 15)
            //{
            //    Console.WriteLine("bao tri");
            //}
            //else 
            //{
            //    Console.WriteLine("khong co de xuat");
            //}

            #endregion

            #region Bai_-1

            //float thuong = 0;
            //Console.Write("Luong: ");
            //int luong = int.Parse(Console.ReadLine());
            //Console.Write("Gio lam viec: ");
            //int gio = int.Parse(Console.ReadLine());
            //float rate1 = 0.2f;
            //float rate2 = 0.1f;

            //if (gio >= 200)
            //{
            //     thuong = luong * rate1;
            //}
            //else if (gio >= 100 && gio < 200)
            //{
            //     thuong = luong * rate2;
            //}
            //else
            //{
            //     thuong = 0;
            //}
            //Console.WriteLine("Thuong: " + thuong );

            #endregion

            #region Bai_1

            Console.Write("Nhap so N: ");
            float N = float.Parse(Console.ReadLine());

            if((int)N == N)
            {
                Console.WriteLine("N la so nguyen");
                if(N%2 == 0)
                {
                    Console.WriteLine("N la so chan");
                }
                else
                {
                    Console.WriteLine("N la so le");
                }
                if(N % 2 == 0 && N >= 0)
                {
                    Console.WriteLine("N la so chan duong");
                }
                else if(N % 2 == 1 && N >= 0)
                {
                    Console.WriteLine("N la so le duong");
                }
                else if(N < 0 && (-N) % 2 == 0)
                {
                    Console.WriteLine("N la so chan am");
                }
                else if(N < 0 && (-N) % 2 == 1)
                {
                    Console.WriteLine("N la so le am");
                }

                float canBacHaiN = (float)Math.Sqrt(N);
                int phanNguyenCanBacHaiN = (int)canBacHaiN;
                
                if(phanNguyenCanBacHaiN == canBacHaiN)
                {
                    Console.WriteLine("N la so chinh phuong");
                }
                else
                {
                    Console.WriteLine("N ko phai so chinh phuong");
                }
            }
            else
            {
                Console.WriteLine("N la so thap phan");
            }


            



            #endregion

            Console.ReadKey();

        }
    }
}
