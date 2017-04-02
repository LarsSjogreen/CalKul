using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class Parser
    {
        public List<IOperator> Operators { get; set; }

        public Parser()
        {
        }

        public void ParseDo(string input, Stack<double> stack)
        {
            double number;
            if (double.TryParse(input, out number))
            {
                stack.Push(number);
            }
            else if (input.Contains(" "))
            {
                foreach (var arg in input.Split(' '))
                {
                    ParseDo(arg, stack);
                }
            }
            else
            {
                foreach (var op in Operators)
                {
                    if (input == op.OperandName)
                    {
                        var retVal = op.Do(stack);
                        if (retVal != double.MinValue)
                        {
                            stack.Push(retVal);
                        }
                    }
                }
            }
        }
    }
}
