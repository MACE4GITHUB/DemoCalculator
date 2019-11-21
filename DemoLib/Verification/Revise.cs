using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Verification
{
    /// <summary>
    /// Helper Class
    /// </summary>
    public static class Revise
    {
        /// <summary>
        /// Initializes a new instance of the class ArgumentException with an error message and the name of the parameter that caused this exception.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="paramName">Error parameter</param>
        public static void ArgumentException(string message, string paramName = null)
        {
            if (string.IsNullOrEmpty(paramName))
                throw new ArgumentException(message);

            throw new ArgumentException(message, paramName);
        }

        /// <summary>
        /// Initializes a new instance of the class NullReferenceException with an error message
        /// </summary>
        /// <param name="message"></param>
        public static void NullReferenceException(string message)
        {
            throw new NullReferenceException(message);
        }

        /// <summary>
        /// Initializes a new instance of the class DivideByZeroException with an error message
        /// </summary>
        /// <param name="message"></param>
        public static void DivideByZeroException(string message)
        {
            throw new DivideByZeroException(message);
        }
    }
}