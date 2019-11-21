using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.DataModel;
using DemoLib.UI;
using DemoLib.Verification;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Calculator for double numbers.
    /// </summary>
    public class DoubleCalculator : ICalculator<double>
    {
        /// <summary>
        /// Initialization of the calculator.
        /// </summary>
        /// <param name="ui">UI for the calculator.</param>
        /// <param name="data">Data for the calculator.</param>
        public DoubleCalculator(IUI ui, IDataConverter<Data> data)
        {
            UI = ui;
            Data = data;
        }

        /// <summary>
        /// UI for the calculator.
        /// </summary>
        public IUI UI { get; }

        /// <summary>
        /// Data for the calculator.
        /// </summary>
        public IDataConverter<Data> Data { get; }

        /// <summary>
        /// Execution of the calculator.
        /// </summary>
        public void Execute()
        {
            UI.Output(Resource.SignEnter, false);
            var enteredData = UI.Input();
            var sourceData = Data.GetData(enteredData);
            var Operation = GetOperation(sourceData);
            UI.Output(string.Format(Resource.PutResult, Data.GetString(), Operation.Operate().ToString()), true);
        }

        /// <summary>
        /// Get result the calculate operation.
        /// </summary>
        /// <param name="sourceData"></param>
        /// <returns></returns>
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
                    Revise.NullReferenceException(Resource.OperationNotDefined);
                    return null;
            }
        }
    }
}