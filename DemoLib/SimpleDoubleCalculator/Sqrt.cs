using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    public class Sqrt : BaseOperation, IOperation<double>
    {
        public Sqrt(double x, double y = 0) : base(x, y) { }
        public double Operate()
        {
            double result = Math.Sqrt(X);
            if (double.IsNaN(result))
                throw new ArgumentException("Ошибка. Значение X меньше 0.");
            return result;
        }
    }
}
