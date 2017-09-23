using System;

namespace _2_3_method_overloading
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point point)
        {
            if (point == null)
            {
                throw new ArgumentNullException("point");
            }

            Move(point.X, point.Y);
        }
    }
}