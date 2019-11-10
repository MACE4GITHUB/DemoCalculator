using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public interface IUI
    {
        //T GetData(string inputData);
        Action<string, bool> Output { get; }
        Func<string> Input { get; }
    }
}
