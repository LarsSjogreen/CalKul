using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class LessThan : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "<"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var second = args.Pop();
            return ((double)(args.Pop()) < (double)second);
        }
    }
}
