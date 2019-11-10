using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    public class Pow : BaseOperation, IOperation<double>
    {
        public Pow(double x, double y) : base(x, y) { }
        public double Operate()
        {          
            double result = Math.Pow(X, Y);
            if (double.IsInfinity(result))
                throw new ArgumentException("Ошибка. Значение превышает допустимый диапазон для типа double.");
            return result;
        }
    }
}
