using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class Drop : IOperator
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
                return "drop";
            }
        }

        public double Do(Stack<double> args)
        {
            if (args.Count < NumberOfArguments)
            {
                throw new ArgumentException("Wrong number of arguments");
            }
            args.Pop();
            return double.MinValue;
        }
    }
}
