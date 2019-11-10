using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class Log10Tests
    {
        [Test]
        public void WhenX100_Should2(
            [Values(100)]double x)
        {    
            var operation = new Log10(x);
            Assert.AreEqual(2, operation.Operate());
        }
        [Test]
        public void WhenXNegative100_ShouldArgumentException(
            [Values(-100)]double x)
        {
            var operation = new Log10(x);
            Assert.Throws<ArgumentException>(() => { var result = operation.Operate(); });
        }
    }
}