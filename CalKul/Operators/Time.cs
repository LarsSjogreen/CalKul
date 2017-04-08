using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Time : IOperator
    {
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "time"; }
        }

        public object Do(Stack<object> args)
        {
            double time;
            string timeString = DateTime.Now.Hour + "," + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;

            if (double.TryParse(timeString, out time))
                return time;
            else
                throw new Exception("Error parsing time");
        }
    }
}
