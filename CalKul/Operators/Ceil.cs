using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Ceil : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "ceil"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Ceiling((double)args.Pop());
        }
    }
}
