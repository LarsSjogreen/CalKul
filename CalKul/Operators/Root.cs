using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Root : IOperator
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
                return "root";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            if ((double)args.Peek() < 0)
            {
                throw new ArgumentException("Argument is less than zero");
            }
            return Math.Sqrt((double)(args.Pop()));
        }
    }
}