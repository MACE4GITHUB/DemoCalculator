using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IDataConverter<T>
    {
        T GetData( string inputData);
        string GetString();
    }
}
