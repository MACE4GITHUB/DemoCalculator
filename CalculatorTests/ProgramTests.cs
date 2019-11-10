using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.UI.Cmd;
using DemoLib.UI;
using DemoLib.SimpleCalculator;

namespace DemoLib.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        private static double Execute(Func<string> input)
        {
            void output(string a, bool b) { }

            IUI<InputData> ui = new CmdData(input, output);

            ICalculator<double> calculator = new DecCalculator();

            var result = calculator.Execute(ui);
            return result;
        }

        [TestMethod()]
        public void Main_WhenX1BadY1_ShouldCach()
        {
            Func<string> input = () => "1 kj1";

            Assert.ThrowsException<Exception>(() =>
            {
                var result = Execute(input);
            });
        }
    }
}