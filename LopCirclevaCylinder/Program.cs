using System;

namespace LopCirclevaCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle ci = new Circle(3,"yellow");
            Console.WriteLine(ci.ToString());
            Cylinder cy = new Cylinder(10,"whille",2);
            Console.WriteLine(cy.ToString());
            Console.ReadLine();
        }
    }
}
