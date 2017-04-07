using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Floor : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "floor"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Floor((double)args.Pop());
        }
    }
}
