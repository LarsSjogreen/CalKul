﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Pi : IOperator
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
            get { return "pi"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.PI;
        }
    }
}
