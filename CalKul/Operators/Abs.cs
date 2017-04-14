using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Abs : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "abs"; }
        }

        public object Do(Stack<object> args)
        {
            return Math.Abs((double)args.Pop());
        }
    }
}
