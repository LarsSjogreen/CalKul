using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class Root : IOperator
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

        public double Do(Stack<double> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Sqrt(args.Pop());
        }
    }
}