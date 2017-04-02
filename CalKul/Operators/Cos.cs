using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class Cos : IOperator
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
                return "cos";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Cos((double)args.Pop());
        }
    }
}