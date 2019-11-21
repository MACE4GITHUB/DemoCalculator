﻿using DemoLib.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Returns the multiply of two double numbers
    /// </summary>
    public class Multiply : BaseOperation, IOperation<double>
    {
        /// <summary>
        /// Initializes two double numbers
        /// </summary>
        /// <param name="x">X number</param>
        /// <param name="y">Y number</param>
        public Multiply(double x, double y) : base(x, y) { }

        /// <summary>
        /// Calculates the multiply of two double numbers
        /// </summary>
        /// <returns>X * Y</returns>
        public double Operate()
        {
            double result = X * Y;

            if (double.IsInfinity(result))
                Revise.ArgumentException(Resource.OutOfRange, nameof(result));            

            return result;
        }
    }
}