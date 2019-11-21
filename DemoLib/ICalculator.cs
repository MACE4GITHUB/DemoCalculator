using DemoLib.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    /// <summary>
    /// Interface of Calculator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICalculator<T>
    {
        /// <summary>
        /// Get result the calculate operation.
        /// </summary>
        /// <param name="sourceData"></param>
        /// <returns></returns>
        IOperation<T> GetOperation(IData<T> sourceData);

        /// <summary>
        /// Execution of the calculator.
        /// </summary>
        void Execute();
    }
}