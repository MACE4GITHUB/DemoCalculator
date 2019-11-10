using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class DivideTests
    {
        [Test]
        public void WhenX1Y0_ShouldThrowDivideByZero(
            [Values(1)]double x,
            [Values(0)]double y
            )
        {           
            var operation = new Divide(x, y);
            Assert.Throws<DivideByZeroException>(() => { var result = operation.Operate(); });
        }
        [Test]
        public void WhenX12Y4_ShouldResult3(
            [Values(12)]double x,
            [Values(4)]double y
            )
        {            
            var operation = new Divide(x, y);
            Assert.AreEqual(3, operation.Operate());
        }
    }
}