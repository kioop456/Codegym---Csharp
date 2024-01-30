using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Bai_tap__Ung_dung_doc_so_thanh_chu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can doc:");
            Console.Write("Ones: ");
            int Ones = int.Parse(Console.ReadLine());
            Console.Write("Tens: ");
            int Tens = int.Parse(Console.ReadLine());
            Console.Write("Hundreds: ");
            int Hundreds = int.Parse(Console.ReadLine());
            Console.WriteLine("So can doc: "  + Hundreds + Tens + Ones);
            if (Tens == 1)
            {
                switch (Ones)
                {
                    case 0:
                        Console.WriteLine("Ten");
                        break;
                    case 1:
                        Console.WriteLine("Eleven");
                        break;
                    case 2:
                        Console.WriteLine("Twevle");
                        break;
                    case 3:
                        Console.WriteLine("Thirdteen");
                        break;
                    case 4:
                        Console.WriteLine("Fourteen");
                        break;
                    case 5:
                        Console.WriteLine("Fifteen");
                        break;
                    case 6:
                        Console.WriteLine("Sixteen");
                        break;
                    case 7:
                        Console.WriteLine("Seventeen");
                        break;
                    case 8:
                        Console.WriteLine("Eighteen");
                        break;
                    case 9:
                        Console.WriteLine("Nineteen");
                        break;
                    default:
                        Console.WriteLine("Out of ability");
                        break;
                }
            }
            else if (Tens != 1 && Tens < 10)
            {
                    switch (Ones)
                    {
                        case 0:
                            Console.WriteLine("");
                            break;
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                        default:
                            Console.WriteLine("Out of ability");
                            break;
                    }
                    switch(Tens)
                    {
                        case 0:
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.WriteLine("Twenty");
                            break;
                        case 3:
                            Console.WriteLine("Thirdty");
                            break;
                        case 4:
                            Console.WriteLine("Forty");
                            break;
                        case 5:
                            Console.WriteLine("Fifty");
                            break;
                        case 6:
                            Console.WriteLine("Sixty");
                            break;
                        case 7:
                            Console.WriteLine("Seventy");
                            break;
                        case 8:
                            Console.WriteLine("Eighty");
                            break;
                        case 9:
                            Console.WriteLine("Ninety");
                            break;
                        default:
                            Console.WriteLine("Out of ability");
                            break;
                    }
                switch(Hundreds)
                {
                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("One hundred");
                        break;
                    case 2:
                        Console.WriteLine("Two hundred");
                        break;
                    case 3:
                        Console.WriteLine("Three hundred");
                        break; 
                    case 4:
                        Console.WriteLine("Four hundred");
                        break;
                    case 5:
                        Console.WriteLine("Five hundred");
                        break;
                    case 6:
                        Console.WriteLine("Six hundred");
                        break;
                    case 7:
                        Console.WriteLine("Seven hundred");
                        break;
                    case 8:
                        Console.WriteLine("Eight hundred");
                        break;
                    case 9:
                        Console.WriteLine("Nine hundred");
                        break;
                    default :
                        Console.WriteLine("Out of ability");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Out of ability");
            }
            Console.ReadKey();

        }


    }
}
