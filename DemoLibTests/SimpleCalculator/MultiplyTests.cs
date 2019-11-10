using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void WhenXMaxValueY2_ShouldArgumentException(
            [Values(double.MaxValue)]double x,
            [Values(2)]double y
            )
        {            
            var operation = new Multiply(x, y);
            Assert.Throws<ArgumentException>(() => { var result = operation.Operate(); });
        }
        [Test]
        public void WhenX2Y3_ShouldResult6(
            [Values(2)]double x,
            [Values(3)]double y
            )
        {           
            var operation = new Multiply(x, y);
            Assert.AreEqual(6, operation.Operate());
        }
    }
}