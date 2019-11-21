using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    /// <summary>
    /// Interface of data for the calculator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IData<T>
    {
        /// <summary>
        /// Operation for the calculator
        /// </summary>
        string Operation { get; }

        /// <summary>
        /// Value X for the calculator
        /// </summary>
        T X { get; }

        /// <summary>
        /// Value Y for the calculator
        /// </summary>
        T Y { get; }
    }
}