namespace PiCalculator
{
    public class Circle
    {
        public bool IsPointInside(MyPoint point)
        {

            if (point.GetDistanceFromAnotherPoint(new MyPoint(0, 0)) <= 1)
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