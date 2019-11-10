using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class SubtractTests
    {
        [Test]
        public void WhenXandYMaxValue_ShouldThrowArgumentOutOfRange(
            [Values(double.MaxValue)]double x,
            [Values(double.MaxValue)]double y)
        {
            var operation = new Subtract(x, y);
            Assert.AreEqual(0, operation.Operate());
        }
        [Test]
        public void WhenXorYNaN_ShouldArgumentException(
            [Values(double.NaN)]double x,
            [Values(double.NaN)]double y)
        {
            Assert.Throws<ArgumentException>(() => { var operation = new Subtract(x, y); });
        }
        [Test]
        public void WhenXorYInfinity_ShouldArgumentException(
            [Values(double.MaxValue + double.MaxValue)]double x,
            [Values(double.MaxValue + double.MaxValue)]double y)
        {
            Assert.Throws<ArgumentException>(() => { var operation = new Subtract(x, y); });
        }
        [Test]
        public void WhenXMaxValueYMinValue_ShouldArgumentException(
            [Values(double.MaxValue)]double x,
            [Values(double.MinValue)]double y)
        {
            var operation = new Subtract(x, y);
            Assert.Throws<ArgumentException>(() => {var result = operation.Operate(); });
        }
        [Test]
        public void SubtractXYPositive(
            [Values(2, 3)]double x,
            [Values(4, 5)]double y
            )
        {
            var operation = new Subtract(x, y);
            Assert.AreEqual(x - y, operation.Operate());
        }
        [Test]
        public void SubtractXYNegative(
            [Values(-2, -3)]double x,
            [Values(-4, -5)]double y
            )
        {
            var operation = new Subtract(x, y);
            Assert.AreEqual(x - y, operation.Operate());
        }
    }
}