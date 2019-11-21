using DemoLib;
using DemoLib.Converters;
using DemoLib.SimpleDoubleCalculator;
using DemoLib.UI;
using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            UserInterface ui = new UserInterface();
            var dataConverter = new CmdData();

            ICalculator<double> calculator = new DoubleCalculator(ui, dataConverter);

            ui.Output(ResourceCalculator.InitialMessage, true);

            while (true)
            {
                try
                {
                    calculator.Execute();                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("{0}\r\n{1}\r\n{2}", ResourceCalculator.ErrorsCalculations, e.Message, ResourceCalculator.ShutDownCalculator));

                    if (Console.ReadLine().ToLowerInvariant() == "y")
                    {
                        throw;                        
                    }
                }
            }
        }
    }
}