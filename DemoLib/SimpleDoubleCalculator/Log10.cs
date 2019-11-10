using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    public class Log10 : BaseOperation, IOperation<double>
    {
        public Log10(double x, double y = 0) : base(x, y) { }
        public double Operate()
        {
            double result = Math.Log10(X);
            if (double.IsNaN(result))
                throw new ArgumentException("Ошибка. Значение X меньше 0.");
            return result;
        }
    }
}
