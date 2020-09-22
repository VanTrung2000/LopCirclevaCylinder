using System;
using System.Collections.Generic;
using System.Text;

namespace LopCirclevaCylinder
{
    class Circle
    {
        public double r;
        public string color;

        public Circle() { }
        public Circle(double r,string color)
        {
            this.r = r;
            this.color = color;
        }
        public void Setbankinh(double r)
        {
            r = r;
        }
        public double Getbankinh()
        {
            return r;
        }
        public void Setcolor(string color)
        {
            color = color;
        }
        public string Getcolor()
        {
            return color;
        }
        public double area()
        {
            return Math.PI * r * r;
        }
        public override string ToString()
        {
            return "Co R = " + Getbankinh() + "  Area =  " + area() + "  Color: " + Getcolor();
        }


    }
}
