using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Fp : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "fp"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var number = (double)(args.Pop());
            if (number > 0)
            {
                return number - Math.Floor(number);
            }
            else
            {
                return - Math.Ceiling(number) + number;
            }
        }
    }
}
