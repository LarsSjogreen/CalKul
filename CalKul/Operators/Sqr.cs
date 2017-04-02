using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
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

        public double Do(Stack<double> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var value = args.Pop();
            return value * value;
        }
    }
}
