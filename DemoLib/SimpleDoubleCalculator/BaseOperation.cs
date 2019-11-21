using DemoLib.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    /// <summary>
    /// Base class for all operations
    /// </summary>
    public class BaseOperation
    {
        /// <summary>
        /// Initializing X, Y and checking their values.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public BaseOperation(double x, double y)
        {
            X = x;
            Y = y;
            СheckXY();
        }

        /// <summary>
        /// X value.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Y value.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Checking X, Y values.
        /// </summary>
        private void СheckXY()
        {
            StringBuilder error = new StringBuilder();

            if (double.IsNaN(X)) 
                AddError(Resource.UnableX);

            if (double.IsNaN(Y))
                AddError(Resource.UnableY);

            if (double.IsInfinity(X))
                AddError(Resource.OutOfRangeX);

            if (double.IsInfinity(Y))
                AddError(Resource.OutOfRangeY);

            if (error.Length > 0)
                Revise.ArgumentException(GetResultErrors());

            #region Helpers
            void AddError(string message)
            {
                if (error.Length > 0) error.Append(GetNewLine());
                error.AppendFormat(message);
            }

            string GetNewLine()
            {
                return Environment.NewLine;
            }

            string GetResultErrors()
            {
                return string.Format("{0}{1}{2}", Resource.UnableCompleteOperation, GetNewLine(), error.ToString());
            }
            #endregion
        }
    }
}