using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CalKul.Operators
{
    public class Wait : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "wait"; }
        }

        public object Do(Stack<object> args)
        {
            double duration = (double)args.Pop();
            Thread.Sleep((int)(duration * 1000));
            return null;
        }
    }
}
