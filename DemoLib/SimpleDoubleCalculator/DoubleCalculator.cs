using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.DataModel;
using DemoLib.UI;

namespace DemoLib.SimpleDoubleCalculator
{
    public class DoubleCalculator : ICalculator<double>
    {
        public DoubleCalculator(IUI ui, IDataConverter<Data> data)
        {
            UI = ui;
            Data = data;
        }
        public IUI UI { get; }     
        public IDataConverter<Data> Data { get; }  
        public void Execute()
        {
            UI.Output(">", false);
            var enteredData = UI.Input();
            var sourceData = Data.GetData(enteredData);
            var Operation = GetOperation(sourceData);
            UI.Output(string.Format("Результат: {0} = {1}", Data.GetString(), Operation.Operate().ToString()), true);
        }
        public IOperation<double> GetOperation(IData<double> sourceData)
        {
            switch (sourceData.Operation)
            {
                case "+":
                    return new Add(sourceData.X, sourceData.Y);
                case "-":
                    return new Subtract(sourceData.X, sourceData.Y);
                case "/":
                    return new Divide(sourceData.X, sourceData.Y);
                case "%":
                    return new Remain(sourceData.X, sourceData.Y);
                case "*":
                    return new Multiply(sourceData.X, sourceData.Y);
                case "^":
                    return new Pow(sourceData.X, sourceData.Y);
                case "sqrt":
                    return new Sqrt(sourceData.X);
                case "log10":
                    return new Log10(sourceData.X);
                default:
                    throw new NullReferenceException("Операция не определена.");
            }
        }
    }
}