using DemoLib.DataModel;
using Moq;
using NUnit.Framework;
using System;

namespace DemoLib.SimpleDoubleCalculator.Tests
{
    [TestFixture]
    public class DecCalculatorTests
    {
        [Test]
        public void ExecuteOK(
            [Values(1)]double x,
            [Values(2)]double y,
            [Values("+", "-", "/", "*", "%", "log10", "sqrt", "^")]string operation
            )
        {
            string inputData = x.ToString() + " " + operation + " " + y;
            var mockUserInterface = new Mock<IUI>();
            mockUserInterface.Setup((_) => _.Input).Returns(() => inputData);
            mockUserInterface.Setup((_) => _.Output).Returns((a, __) => { Console.WriteLine(a); });

            var mockdataConverter = new Mock<IDataConverter<Data>>();
            mockdataConverter.Setup((_) => _.GetData(inputData)).Returns(new Data(x, y, operation));

            ICalculator<double> calculator = new DoubleCalculator(mockUserInterface.Object, mockdataConverter.Object);
            calculator.Execute();
        }
        [Test]
        public void ExecuteExeption(
            [Values(1)]double x,
            [Values(2)]double y,
            [Values("NAN")]string operation
            )
        {
            string inputData = x.ToString() + " " + operation + " " + y;
            var mockUserInterface = new Mock<IUI>();
            mockUserInterface.Setup((_) => _.Input).Returns(() => inputData);
            mockUserInterface.Setup((_) => _.Output).Returns((a, __) => { Console.WriteLine(a); });

            var mockdataConverter = new Mock<IDataConverter<Data>>();
            mockdataConverter.Setup((_) => _.GetData(inputData)).Returns(new Data(x, y, operation));

            ICalculator<double> calculator = new DoubleCalculator(mockUserInterface.Object, mockdataConverter.Object);
            Assert.Throws<NullReferenceException>(
                () => calculator.Execute()
                );            
        }
    }
}