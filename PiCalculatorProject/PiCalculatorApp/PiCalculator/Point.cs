using System;

namespace PiCalculator
{
    public class MyPoint
    {
        public double X { get; }
        public double Y { get; }

        public MyPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetDistanceFromAnotherPoint(MyPoint point)
        {
            var A = point.X - this.X;
            var B = point.Y - this.Y;

            var d = Math.Sqrt(A * A + B * B);

            return d;
        }
    }
}