using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {

        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Distance(Point X2)
        {
            return (double)Math.Sqrt(Math.Pow((X2.X - this.X), 2) + Math.Pow((X2.Y - this.Y), 2));
        }

        public bool Check(Point X2)
        {
            if (this.X == X2.X && this.Y == X2.Y)
            {
                return false;
            }
            return true;
        }
    }
}
