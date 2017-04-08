using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Date : IOperator
    {
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "date"; }
        }

        public object Do(Stack<object> args)
        {
            double date;
            string datestring = DateTime.Now.Month + "," + DateTime.Now.Day + DateTime.Now.Year;

            if (double.TryParse(datestring, out date))
                return date;
            else
                throw new Exception("Error parsing datetime");
        }
    }
}
