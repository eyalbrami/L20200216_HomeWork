using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20200216_HomeWork
{
    public abstract class Shape
    {
        public double length { get; set; }
        public double heigth { get; set; }
        public abstract double GetArea();
    }
    public class Rectangle : Shape
    {
        public Rectangle(double length, double heigth)
        {
            this.length = length;
            this.heigth = heigth;
        }
        public override double GetArea()
        {
            return this.length * this.heigth;
        }
        public double GetPerimeter()
        {
            return (this.length + this.heigth) * 2;
        }
    }
    public class Square : Rectangle
    {
        public Square(double length, double height) : base(length, height) { }
    }
}
