using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class RemainTests
    {
        [Test]
        public void WhenX1Y0_ShouldThrowDivideByZero(
            [Values(1)]double x,
            [Values(0)]double y
            )
        {
            var operation = new Remain(x, y);
            Assert.Throws<DivideByZeroException>(() => { var result = operation.Operate(); });
        }
        [Test]
        public void WhenX13Y4_ShouldResult3(
            [Values(13)]double x,
            [Values(4)]double y
            )
        {
            var operation = new Remain(x, y);
            Assert.AreEqual(1, operation.Operate());
        }
    }
}