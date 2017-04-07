using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Square : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 1;
            }
        }

        public string OperandName
        {
            get
            {
                return "sqr";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var value = (double)args.Pop();
            return value * value;
        }
    }
}
