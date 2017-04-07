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
            // String addition is non commutative. Thats why the fiddling around with the temporary var
            else if (OperatorUtils.IsString(args, this.NumberOfArguments))
            {
                var secondString = args.Pop();
                StringBuilder sb = new StringBuilder((string)args.Pop());
                return sb.Append(secondString).ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
