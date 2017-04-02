using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class Xroot : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "xroot"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckNumberOfArguments(args, this.NumberOfArguments);
            var x = (double)args.Pop();
            var y = (double)args.Pop();
            return Math.Pow(y, 1.0 / x);
        }
    }
}
