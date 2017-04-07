using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Rand : IOperator
    {
        Random ran = new Random(DateTime.Now.Millisecond);
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "rand"; }
        }

        public object Do(Stack<object> args)
        {
            return ran.NextDouble();
        }
    }
}
