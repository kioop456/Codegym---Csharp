using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03____Bai_tap__Hien_thi_cac_loai_hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print the isosceles triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Vui long chon menu: ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        int chieuDai; int chieuRong;
                        Console.Write("Enter chieuDai: ");
                        chieuDai = int.Parse(Console.ReadLine());
                        Console.Write("Enter chieuRong: ");
                        chieuRong = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        for (int i = 1; i <= chieuDai;i++)
                        {
                            for(int j = 0; j < chieuRong; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Vui long chon vi tri canh goc vuong");
                        Console.WriteLine("1. top-left");
                        Console.WriteLine("2. bottom-left");
                        Console.WriteLine("3. top-right");
                        Console.WriteLine("4. bottom-right");
                        Console.Write("Enter your choice: ");
                        int luaChon;
                        luaChon = int.Parse(Console.ReadLine());
                        int chieuCao;
                        Console.Write("Enter chieuCao: ");
                        chieuCao = int.Parse(Console.ReadLine());
                        int a; int b;
                        switch (luaChon)
                        {
                            case 1:
                                Console.WriteLine("top-left");
                                Console.WriteLine("");
                                for (a = chieuCao; a >= 1; a--)
                                {
                                    for (b = 1; b <= a; b++)
                                    {
                                        Console.Write("*");
                                    }
                                    Console.WriteLine("");
                                }
                                Console.WriteLine("");
                                break;

                            case 2:
                                Console.WriteLine("bottom-left");
                                Console.WriteLine("");
                                for (a = 1; a <= chieuCao; a++)
                                {
                                    for (b = 1; b <= a; b++)
                                    {
                                        Console.Write("*");
                                    }
                                    Console.WriteLine("");
                                }
                                Console.WriteLine("");
                                break;
                            
                            case 3:
                                Console.WriteLine("top-right");
                                Console.WriteLine("");
                                for (a = 1; a <= chieuCao; a++)
                                {
                                    for (b = 1; b <=a; b++)
                                    {
                                        Console.Write("");
                                        int c = a - b;
                                        for(c = 0; c >= 0;)
                                        {
                                            Console.Write("*");
                                        }
                                    }
                                }
                                break;
                        }
                        break;

                        

                    //case 4:
                    //    Environment.ExitCode = 0;
                    //    break;
                    //default:
                    //    Console.WriteLine("No choice");
                    //    break;

                }
            }


            Console.ReadKey();
        }
    }
}
