using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Buoi10_
{
    public abstract class Animal
    {
        protected double weight;
        protected double height;

        public double Weight => weight;
        public double Height => height;
        public Animal(double height, double weight)
        {
            this.height= height;
            this.weight = weight;
            Console.WriteLine("Khoi tao animal ");
        }
        public abstract void makeSound();
    }

    
    public class Cat: Animal
    {
        bool canCatchMouse;

        public Cat(double height, double weight, bool canCatchMouse) : base(weight, height)
        {
            this.canCatchMouse = canCatchMouse;
        }

        public override void makeSound()
        {
            Console.WriteLine("meo meo");
        }

    }

    public class Dog: Animal
    {
        bool choNghiepVu;

        public Dog(double height, double weight, bool choNghiepVu) :base(weight, height)
        {
            this.choNghiepVu = choNghiepVu;
        }

        public override void makeSound()
        {
            Console.WriteLine("gau gau");
        }
    }

}
