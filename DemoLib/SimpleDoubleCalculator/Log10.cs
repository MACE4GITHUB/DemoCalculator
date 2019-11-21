using DemoLib.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Returns the Log10 of two double numbers
    /// </summary>
    public class Log10 : BaseOperation, IOperation<double>
    {
        /// <summary>
        /// Initializes two double numbers
        /// </summary>
        /// <param name="x">X number</param>
        /// <param name="y">Y number</param>
        public Log10(double x, double y = 0) : base(x, y) { }

        /// <summary>
        /// Calculates the Log10 of two double numbers
        /// </summary>
        /// <returns>Log10(X)</returns>
        public double Operate()
        {
            double result = Math.Log10(X);

            if (double.IsNaN(result))
                Revise.ArgumentException(Resource.ValueOfXLessThanZero, nameof(X));                

            return result;
        }
    }
}