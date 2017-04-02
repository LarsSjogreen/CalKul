﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class Minus : IOperator
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
                return "-";
            }
        }

        public double Do(Stack<double> args)
        {
            OperatorUtils.CheckArgs(args, this);
            double subtractor = args.Pop();
            return args.Pop() - subtractor;
        }
    }
}
