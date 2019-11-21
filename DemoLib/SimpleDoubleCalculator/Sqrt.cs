using DemoLib.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Returns the sqrt of two double numbers
    /// </summary>
    public class Sqrt : BaseOperation, IOperation<double>
    {
        /// <summary>
        /// Initializes two double numbers
        /// </summary>
        /// <param name="x">X number</param>
        /// <param name="y">Y number</param>
        public Sqrt(double x, double y = 0) : base(x, y) { }

        /// <summary>
        /// Calculates the sqrt of two double numbers
        /// </summary>
        /// <returns>Sqrt(X)</returns>
        public double Operate()
        {
            double result = Math.Sqrt(X);

            if (double.IsNaN(result))
                Revise.ArgumentException(Resource.ValueOfXLessThanZero, nameof(X));

            return result;
        }
    }
}