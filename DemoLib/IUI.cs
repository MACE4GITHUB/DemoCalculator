using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    /// <summary>
    /// Interface UI for the calculator
    /// </summary>
    public interface IUI
    {
        /// <summary>
        /// Output Message for the calculator
        /// </summary>
        Action<string, bool> Output { get; }

        /// <summary>
        /// Input string for the calculator
        /// </summary>
        Func<string> Input { get; }
    }
}