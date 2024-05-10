using NUnit.Framework;
using PiCalculator;

namespace PiCalculatorTests
{
    [TestFixture]
    public class MyTestClass
    {
        [Test]
        public void CheckOnePointInCircle_Test()
        {
            double x = 0.3;
            double y = 0.2;

            var point = new Point2D(x, y);
            var circleCenter = new Point2D(0, 0);
            var radiusInCM = 1.0;
            var circle = new Circle(circleCenter, radiusInCM);

            bool isPointInside = circle.IsPointInside(point);

            Assert.AreEqual(true, isPointInside);
        }

        [Test]
        public void CheckPointOutsideCircle()
        {

            var point = new Point2D(10, 10);
            var circleCenter = new Point2D(0, 0);
            var radiusInCM = 1.0;
            var circle = new Circle(circleCenter, radiusInCM);
            bool isPointInside = circle.IsPointInside(point);

            Assert.AreEqual(false, isPointInside);
        }
    }
}