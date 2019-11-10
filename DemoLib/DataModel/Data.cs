using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.DataModel
{
    public class Data : IData<double>
    {
        public Data(double x, double y, string operation)
        {
            X = x;
            Y = y;
            Operation = operation;
        }
        public double X { get; }
        public double Y { get; }
        public string Operation { get; }
    }
}
