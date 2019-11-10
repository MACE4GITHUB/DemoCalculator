using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void WhenNegative_ShouldThrowArgumentException(
            [Values(-1)]double x
            )
        {
            var operation = new Sqrt(x);
            Assert.Throws<ArgumentException>(() => { var result = operation.Operate(); });
        }
        [Test]
        public void WhenX16_ShouldResult4(
            [Values(16)]double x
            )
        {
            var operation = new Sqrt(x);
            Assert.AreEqual(4, operation.Operate());
        }
    }
}