using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Setconfig : IOperator
    {
        IConfigurator _configurator;
        public Setconfig(IConfigurator configurator)
        {
            _configurator = configurator;
        }
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "setconfig"; }
        }

        public object Do(Stack<object> args)
        {
            string key = (string)args.Pop();
            double value = (double)args.Pop();
            int intValue = (int)value;
            _configurator.SetConfig(key, intValue);
            return null;
        }
    }
}
