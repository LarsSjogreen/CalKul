using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Swap : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 2;
            }
        }

        public string OperandName
        {
            get
            {
                return "swap";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var arg1 = args.Pop();
            var arg2 = args.Pop();
            args.Push(arg1);
            return arg2;
        }
    }
}
