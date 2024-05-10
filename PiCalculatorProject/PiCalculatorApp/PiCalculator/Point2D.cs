using System;

namespace PiCalculator
{
    public class Point2D
    {
        public double X { get; }
        public double Y { get; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetDistanceFromAnotherPoint(Point2D point2D)
        {
            var A = point2D.X - this.X;
            var B = point2D.Y - this.Y;

            var d = Math.Sqrt(A * A + B * B);

            return d;
        }
    }
}