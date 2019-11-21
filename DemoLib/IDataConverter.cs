using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    /// <summary>
    /// Interface of data for calculator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataConverter<T>
    {
        /// <summary>
        /// Get Data for calculator.
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        T GetData( string inputData);

        /// <summary>
        /// Get string data for calculator.
        /// </summary>
        /// <returns></returns>
        string GetString();
    }
}