using NUnit.Framework;
using System;

namespace DemoLib.Converters.Tests
{
    [TestFixture]
    public class CmdDataTests
    {
        [Test]
        public void WhenManyArgs_ShouldArgumentException(
            [Values("2 3 4 5", "1")]string inputData
            )
        {
            var cmdData = new CmdData();
            Assert.Throws<ArgumentException>(() =>
            {
                var result = cmdData.GetData(inputData);
            });
        }
        [Test]
        public void When2or3Arguments(
            [Values("q   +  w", "q w", " sdasd - fd  ", " sdf5 * fr ", "  fgh - fgh  ")]string inputData
            )
        {
            var cmdData = new CmdData();
            var result = cmdData.GetData(inputData);
            Assert.IsNotNull(result);
        }
        [Test]
        public void WhenParse3Arguments(
            [Values("   2 * 3 ")]string inputData
            )
        {
            var cmdData = new CmdData();
            var result = cmdData.GetData(inputData);
            Assert.AreEqual(2, result.X);
            Assert.AreEqual("*", result.Operation);
            Assert.AreEqual(3, result.Y);
        }
        [Test]
        public void WhenParse2Arguments(
           [Values("   SQrt 9 ")]string inputData
           )
        {
            var cmdData = new CmdData();
            var result = cmdData.GetData(inputData);
            Assert.AreEqual(9, result.X);
            Assert.AreEqual("sqrt", result.Operation);
            Assert.AreEqual(double.NaN, result.Y);
        }
        [Test()]
        public void GetStringTest(
            [Values(" a   +  b  ")]string inputData
            )
        {
            var cmdData = new CmdData();
            cmdData.GetData(inputData);
            var resultString = cmdData.GetString();
            Assert.AreEqual("a + b", resultString);
        }
    }
}