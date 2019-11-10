using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void WhenXandYMaxValue_ShouldThrowArgumentException(
            [Values(double.MaxValue)]double x,
            [Values(double.MaxValue)]double y)
        {
            var operation = new Add(x, y);
            Assert.Throws<ArgumentException>(() => { var result = operation.Operate(); });
        }
        [Test]
        public void WhenXorYNaN_ShouldArgumentException(
            [Values(double.NaN)]double x,
            [Values(double.NaN)]double y)
        {
            Assert.Throws<ArgumentException>(() => { var operation = new Add(x, y); });
        }
        [Test]
        public void WhenXorYInfinity_ShouldArgumentException(
            [Values(double.MaxValue + double.MaxValue)]double x,
            [Values(double.MaxValue + double.MaxValue)]double y)
        {
            Assert.Throws<ArgumentException>(() => { var operation = new Add(x, y); });
        }
        [Test]
        public void SumXYPositive(
            [Values(2, 3)]double x,
            [Values(4, 5)]double y
            )
        {
            var operation = new Add(x, y);
            Assert.AreEqual(x + y, operation.Operate());
        }
        [Test]
        public void SumXYNegative(
            [Values(-2, -3)]double x,
            [Values(-4, -5)]double y
            )
        {
            var operation = new Add(x, y);
            Assert.AreEqual(x + y, operation.Operate());
        }
    }
}