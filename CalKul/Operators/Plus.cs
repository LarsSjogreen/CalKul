using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class Plus : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 2;
            }
        }

        public string OperandName
        {
            get
            {
                return "+";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            if (OperatorUtils.IsNumeric(args, this.NumberOfArguments))
            {
                return (double)args.Pop() + (double)args.Pop();
            }
            else if (OperatorUtils.IsString(args, this.NumberOfArguments))
            {
                StringBuilder sb = new StringBuilder((string)args.Pop());
                return sb.Append((string)args.Pop());
            }
            else
            {
                return null;
            }
        }
    }
}
