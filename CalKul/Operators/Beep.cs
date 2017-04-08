using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Beep : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "beep"; }
        }

        public object Do(Stack<object> args)
        {
            double duration = (double)args.Pop()*1000;
            double frequency = (double)args.Pop();
            
            Console.Beep((int)frequency, (int)duration);
            return null;
        }
    }
}
