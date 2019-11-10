using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IData<T>
    {
        string Operation { get; }
        T X { get; }
        T Y { get; }
    }
}
