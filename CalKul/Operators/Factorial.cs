using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Factorial : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "!"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var value = (double)args.Pop();
            double result = 1.0;
            for (var i = value; i>0;i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
