namespace PiCalculator
{
    public class Circle
    {
        public Point2D Center { get; }
        public double RadiusInCM { get; }

        public Circle(Point2D center, double radiusInCm)
        {
            Center = center;
            RadiusInCM = radiusInCm;
        }

        public bool IsPointInside(Point2D point2D)
        {

            if (point2D.GetDistanceFromAnotherPoint(Center) <= RadiusInCM)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}