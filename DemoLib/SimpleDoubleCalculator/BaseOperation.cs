using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.SimpleDoubleCalculator
{
    public class BaseOperation
    {
        public BaseOperation(double x, double y)
        {
            X = x;
            Y = y;
            СheckXY();
        }
        public double X { get; }
        public double Y { get; }
        public void СheckXY()
        {
            StringBuilder error = new StringBuilder();
            if (double.IsNaN(X))
                AddError("Ошибка. Невозможно определить значение X.");
            if (double.IsNaN(Y))
                AddError("Ошибка. Невозможно определить значение Y.");
            if (double.IsInfinity(X))
                AddError("Ошибка. Превышен допустимый диапазон для типа double.");
            if (double.IsInfinity(Y))
                AddError("Ошибка. Превышен допустимый диапазон для типа double.");
            if (error.Length > 0)
                throw new ArgumentException("Ошибка. Невозможно выполнить операцию.\r\n" + error.ToString());
            void AddError(string message)
            {
                if (error.Length > 0) error.Append("\r\n");
                error.AppendFormat(message);
            }
        }
    }
}