using System;
using System.Collections.Generic;
using System.Text;

namespace LopCirclevaCylinder
{
    class Cylinder : Circle 
    {
        public double height;
        public Cylinder() { }
        public Cylinder(double height,string color,double r) : base(r, color)
        {
            this.height = height;
        }
         public void Setheight(double height)
        {
            height = height;
        }
         public double Getheight()
        {
            return height;
        }
        public double volume()
        {
            return area() * height;
        }
        public override string ToString()
        {
            return "Height = " + Getheight() + " The tich = " + volume()+" Color: "+Getcolor();
        }

    }

}
