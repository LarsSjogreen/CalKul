using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class Sin : IOperator
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
                return "sin";
            }
        }

        public double Do(Stack<double> args)
        {
            if (args.Count < NumberOfArguments)
            {
                throw new ArgumentException("Wrong number of arguments");
            }
            return Math.Sin(args.Pop());
        }
    }
}
