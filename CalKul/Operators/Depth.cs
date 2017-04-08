using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Depth : IOperator
    {
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "depth"; }
        }

        public object Do(Stack<object> args)
        {
            return args.Count;
        }
    }
}
