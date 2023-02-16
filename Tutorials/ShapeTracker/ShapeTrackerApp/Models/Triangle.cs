using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTrackerApp.Models
{
    public class Triangle
    {
        //declaring fields within the class
        public int Side1;
        public int Side2;
        public int Side3;

        //constructor setup
        public Triangle(int length, int length2, int length3)
        {
            Side1 = length;
            Side2 = length2;
            Side3 = length3;
        }

        //custom class method (aka an instance method) for triangles
        public string CheckType()
        {
            if((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
            {
                return "Not a triangle";
            }
            else if ((Side1 != Side2) && (Side1 != Side3) || (Side2 != Side3))
            {
                return "scalene triangle";
            }
            else if ((Side1 == Side2) && (Side1 == Side3))
            {
                return "equilateral triangle";
            }
            else
            {
                return "isosceles triangle";
            }
        }
    }
}
