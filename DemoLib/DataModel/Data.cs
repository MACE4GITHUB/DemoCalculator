using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.DataModel
{
    /// <summary>
    /// Data for the calculator
    /// </summary>
    public class Data : IData<double>
    {
        /// <summary>
        /// Initialization X, Y, operation for the calculator
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="operation"></param>
        public Data(double x, double y, string operation)
        {
            X = x;
            Y = y;
            Operation = operation;
        }

        /// <summary>
        /// Value X for the calculator
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Value Y for the calculator
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Operation for the calculator
        /// </summary>
        public string Operation { get; }
    }
}