using System;

namespace Buoi12_
{
    public interface IShape
    {
        public double GetArea();
        public double GetPerimeter();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return radius * 2 * Math.PI;
        }

    }
    public class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width * height) * 2;
        }
    }
    
}
