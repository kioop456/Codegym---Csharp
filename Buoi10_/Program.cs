using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_
{
    #region student
    ////    public class Program
    ////    {
    ////        static void Main(string[] args)
    ////        {
    ////            Student studentA = new Student("Cong", 17);

    ////            studentA.Print();
    ////            Console.WriteLine($"Tuoi hoc sinh la {studentA.Age}");


    ////            Console.ReadKey();

    ////        }

    ////    }
    #endregion

    #region Meo
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat(3, 0.1f, true);
            Dog dog1 = new Dog(10, 0.2f, false);

            Console.WriteLine($"Can nang meo la: {cat1.Weight}, Can nang cho la: {dog1.Weight}");
            cat1.makeSound();
            dog1.makeSound();
            Console.ReadKey();
        }
    }


    #endregion
}

