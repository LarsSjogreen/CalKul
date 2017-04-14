using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Equals : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "=="; }
        }

        public List<List<Type>> SupportedTypes
        {
            get
            {
                List<List<Type>> supported = new List<List<Type>>();
                supported.Add(new List<Type>() { typeof(double), typeof(double) });
                supported.Add(new List<Type>() { typeof(bool), typeof(bool) });
                supported.Add(new List<Type>() { typeof(string), typeof(string) });
                return supported;
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            if (OperatorUtils.CheckIsSupportedTypes(args,this.NumberOfArguments,this.SupportedTypes))
            {
                var second = args.Pop();
                var first = args.Pop();
                return (first.Equals(second));
            }
            else
            {
                throw new ArgumentException("These can not be compared");
            }
        }
    }
}
