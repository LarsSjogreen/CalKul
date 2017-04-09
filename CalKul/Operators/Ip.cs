using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Ip : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "ip"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var number = (double)args.Pop();
            if (number > 0)
            {
                return Math.Floor(number);
            }
            else
            {
                return Math.Ceiling(number);
            }
        }
    }
}
