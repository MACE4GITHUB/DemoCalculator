using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    /// <summary>
    /// Interface operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOperation<T>
    {
        /// <summary>
        /// Operate operation
        /// </summary>
        /// <returns></returns>
        T Operate();
    }
}