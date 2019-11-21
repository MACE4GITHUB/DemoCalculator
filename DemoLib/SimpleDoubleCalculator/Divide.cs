using DemoLib.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Returns the divide of two double numbers
    /// </summary>
    public class Divide : BaseOperation, IOperation<double>
    {
        /// <summary>
        /// Initializes two double numbers
        /// </summary>
        /// <param name="x">X number</param>
        /// <param name="y">Y number</param>
        public Divide(double x, double y) : base(x, y) { }

        /// <summary>
        /// Calculates the divide of two double numbers
        /// </summary>
        /// <returns>X / Y</returns>
        public double Operate()
        {
            if (Y == 0)
                Revise.DivideByZeroException(Resource.DivideByZero);           

            return X / Y;
        }
    }
}