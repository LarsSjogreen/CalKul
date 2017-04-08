using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Inv : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "inv"; }
        }

        public object Do(Stack<object> args)
        {
            return -(double)(args.Pop());
        }
    }
}
