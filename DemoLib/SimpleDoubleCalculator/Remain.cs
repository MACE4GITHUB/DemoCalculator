using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    public class Remain : BaseOperation, IOperation<double>
    {
        public Remain(double x, double y) : base(x, y) { }
        public double Operate()
        {
            if (Y == 0)
                throw new DivideByZeroException("Ошибка. Деление на ноль.");
            return X % Y;
        }
    }
}
