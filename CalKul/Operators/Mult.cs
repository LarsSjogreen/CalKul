using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class Mult : IOperator
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
                return "*";
            }
        }

        public double Do(Stack<double> args)
        {
            if (args.Count < NumberOfArguments)
            {
                throw new ArgumentException("Wrong number of arguments");
            }
            return args.Pop() * args.Pop();
        }
    }
}
