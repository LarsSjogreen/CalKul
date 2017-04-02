using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class Dup2 : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "dup2"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var arg1 = args.Pop();
            var arg2 = args.Pop();
            args.Push(arg2);
            args.Push(arg1);
            args.Push(arg2);
            return arg1;
        }
    }
}
