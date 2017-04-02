using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class E : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 0;
            }
        }

        public string OperandName
        {
            get
            {
                return "e";
            }
        }

        public double Do(Stack<double> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.E;
        }
    }
}
