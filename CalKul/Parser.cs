using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalKul
{
    public class Parser
    {
        public List<IOperator> Operators { get; set; }

        public Parser()
        {
        }

        public void ParseDo(string input, Stack<object> stack)
        {
            if (ParseArgumentAndPutOnStack(input, stack))
            {
                
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
                        if (retVal != null)
                        {
                            stack.Push(retVal);
                        }
                    }
                }
            }
        }

        private bool ParseArgumentAndPutOnStack(string input, Stack<object> stack)
        {
            double doubleArg;
            if (double.TryParse(input, out doubleArg))
            {
                stack.Push(doubleArg);
                return true;
            }
            else if (input.StartsWith("\"") && input.EndsWith("\""))
            {
                stack.Push(Regex.Replace(input, "\"",""));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
