using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.SimpleDoubleCalculator;
using DemoLib.UI;
using DemoLib.Converters;

namespace DemoLib
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            UserInterface ui = new UserInterface();
            var dataConverter = new CmdData();
            ICalculator<double> calculator = new DoubleCalculator(ui, dataConverter);

            ui.Output(BeginMessage(), true);

            while (true)
            {
                try
                {
                    calculator.Execute();                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Во время вычислений были ошибки:\r\n" + e.Message + "\r\nЗавершить работу калькулятора? (Y - да)");
                    if (Console.ReadLine().ToLowerInvariant() == "y")
                    {
                        throw;
                    }
                }
            }
        }
        static string BeginMessage()
        {
            return @"Допустимые операции:
+ сложение. Например: 2 + 8.
- вычитание. Например: 45 - 6.
/ деление. Например: 12 / 4.
% остаток от деления. Например: 9 % 3.
* умножение. Например:  8,2 * 2.
^ степень числа;. Например 2 ^ 9.
sqrt корень квадратный. Например: sqrt 16.
log10 логарифм с основанием 10. Например: log10 1000.

Цифры и операции должны быть разделены пробелами.
Команда для закрытия калькулятора: exit
";
        }
    }
}
