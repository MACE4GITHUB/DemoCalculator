using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.UI
{
    /// <summary>
    /// User Interface for the calculator
    /// </summary>
    public class UserInterface : IUI
    {
        /// <summary>
        /// Output Message for the calculator
        /// </summary>
        public Action<string, bool> Output => OutPutMessage;

        /// <summary>
        /// Input string for the calculator
        /// </summary>
        public Func<string> Input => Console.ReadLine;

        private void OutPutMessage(string res, bool line)
        {
            if (line)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.Write(res);
            }
        }
    }
}