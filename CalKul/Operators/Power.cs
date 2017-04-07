using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Power : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "pow"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckNumberOfArguments(args, this.NumberOfArguments);
            var y = (double)args.Pop();
            var x = (double)args.Pop();
            return Math.Pow(x, y);
        }
    }
}
