using DemoLib.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Returns the pow of two double numbers
    /// </summary>
    public class Pow : BaseOperation, IOperation<double>
    {
        /// <summary>
        /// Initializes two double numbers
        /// </summary>
        /// <param name="x">X number</param>
        /// <param name="y">Y number</param>
        public Pow(double x, double y) : base(x, y) { }

        /// <summary>
        /// Calculates the pow of two double numbers
        /// </summary>
        /// <returns>Pow(X, Y)</returns>
        public double Operate()
        {          
            double result = Math.Pow(X, Y);

            if (double.IsInfinity(result))
                Revise.ArgumentException(Resource.OutOfRange, nameof(result));

            return result;
        }
    }
}