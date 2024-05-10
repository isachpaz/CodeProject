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

            var point = new MyPoint(x, y);
            var circle = new Circle();
            bool isPointInside = circle.IsPointInside(point);

            Assert.AreEqual(true, isPointInside);
        }

        [Test]
        public void CheckPointOutsideCircle()
        {

            var point = new MyPoint(10, 10);
            var circle = new Circle();
            bool isPointInside = circle.IsPointInside(point);

            Assert.AreEqual(false, isPointInside);
        }
    }
}