using DemoLib.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface ICalculator<T>
    {
        IOperation<T> GetOperation(IData<T> sourceData);
        void Execute();
    }
}
