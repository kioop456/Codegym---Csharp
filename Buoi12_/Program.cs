using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buoi12_
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //    IShape[] shapes = new IShape[]
            //    {
            //        new Circle(3),
            //        new Circle(4),
            //        new Rectangle(3,5),
            //        new Rectangle(4,5),
            //    };

            //    for(int i = 0; i < shapes.Length; i++)
            //    {
            //        Console.WriteLine($"Dien tich la 
            //    }
            //}
            //public static void BaiTapStopWatch
            //{
            //    Random rnd = new Random(); 
            //    int[] arr = new int[10000];
            //    for(int i = 0, i < arr.Length; i++)
            //    {
            //        arr[i] = (int)rnd.Next(500);
            //    }

            //    StopWatch sw = new StopWatch();
            //    sw.Start();
            //    for(int i = 0; i < arr.Length- 1; i++)
            //    {
            //        int minIndex = i;
            //        int minCurrent = arr[i];
            //        for (int j = i + 1; j < arr.lenght; j++)
            //        {
            //            if (minCurrent > arr[j])
            //            {
            //                minCurrent = arr[j];
            //                minIndex = j;
            //            }
            //            int temp = arr[minIndex];
            //            arr[minIndex] = arr[i];
            //            arr[i] = temp;
            //        }
            //        sw.Stop();
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //        Console.WriteLine("Thoi gian chay");
            //}


            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }

            Console.ReadKey();
        }
    }
}
