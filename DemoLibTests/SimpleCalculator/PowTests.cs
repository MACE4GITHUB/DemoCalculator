using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class PowTests
    {
        [Test]
        public void WhenXMaxValueY2_ShouldArgumentException(
            [Values(double.MaxValue)]double x,
            [Values(2)]double y
            )
        {
            var operation = new Pow(x, y);
            Assert.Throws<ArgumentException>(() => { var result = operation.Operate(); });
        }
        [Test]
        public void WhenX2Y3_ShouldResult8(
            [Values(2)]double x,
            [Values(3)]double y
            )
        {
            var operation = new Pow(x, y);
            Assert.AreEqual(8, operation.Operate());
        }
        [Test]
        public void WhenX2YMaxValue_ShouldResult8(
            [Values(2)]double x,
            [Values(double.MaxValue)]double y
            )
        {
            var operation = new Pow(x, y);
            Assert.Throws<ArgumentException>(() => { var result = operation.Operate(); });
        }
    }
}