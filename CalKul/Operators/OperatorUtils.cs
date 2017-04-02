using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public static class OperatorUtils
    {
        public static void CheckArgs(Stack<double> args, IOperator op)
        {
            if (args.Count < op.NumberOfArguments)
            {
                throw new ArgumentException("Wrong number of arguments");
            }
        }
    }
}
