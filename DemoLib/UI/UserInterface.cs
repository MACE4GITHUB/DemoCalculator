using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.UI
{
    public class UserInterface : IUI
    {
        public Action<string, bool> Output => OutPutMessage;

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
