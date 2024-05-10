namespace PiCalculator
{
    public class Circle
    {
        
        public bool IsPointInside(Point2D point2D)
        {

            if (point2D.GetDistanceFromAnotherPoint(new Point2D(0, 0)) <= 1)
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