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
        private IVariableStorage _storage;

        public List<IOperator> Operators { get; set; }

        public Parser(IVariableStorage storage)
        {
            _storage = storage;
        }

        public void ParseDo(string input, Stack<object> stack)
        {
            input = input.Trim();
            if (IsProgramStructure(input,stack))
            {

            }
            else if (ParseArgumentAndPutOnStack(input, stack))
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

                foreach (var variable in _storage.GetAllKeys())
                {
                    if (input == variable)
                    {
                        Eval(_storage.GetValue(variable), stack);
                    }
                }
            }
        }

        private bool IsProgramStructure(string input, Stack<object> stack)
        {
            if (input.StartsWith("if ") && input.EndsWith(" end"))
            {
                List<string> clauses = SplitIfThenElse(input);
                ParseDo(clauses[0], stack);
                var result = stack.Pop();
                if ((typeof(bool) == result.GetType()) && (bool)result == true)
                {
                    ParseDo(clauses[1], stack);
                }
                else if (clauses.Count == 3)
                {
                    ParseDo(clauses[2], stack);
                }
                return true;
            }
            return false;
        }

        private List<string> SplitIfThenElse(string input)
        {
            List<string> dummy = new List<string>();
            dummy.Add(input.Substring(3, input.IndexOf("then") - 3));
            if (input.Contains("else"))
            {
                dummy.Add(input.Substring(input.IndexOf("then") + 5, input.IndexOf("else") - input.IndexOf("then") - 6));
                dummy.Add(input.Substring(input.IndexOf("else") + 5, input.IndexOf("end") - input.IndexOf("else") - 6));
            } else
            {
                dummy.Add(input.Substring(input.IndexOf("then") + 5, input.IndexOf("end") - input.IndexOf("then") - 6));
            }
            return dummy;
        }

        private void Eval(object variableValue, Stack<object> stack)
        {
            if (variableValue.GetType() == typeof(RPLProgram))
            {
                ParseDo(variableValue.ToString(), stack);
            }
            else
            {
                stack.Push(variableValue);
            }
        }

        private bool ParseArgumentAndPutOnStack(string input, Stack<object> stack)
        {
            double doubleArg;
            bool boolArg;
            if (double.TryParse(input, out doubleArg))
            {
                stack.Push(doubleArg);
                return true;
            }
            else if (bool.TryParse(input, out boolArg))
            {
                stack.Push(boolArg);
                return true;
            }
            else if (input.StartsWith("§") && input.EndsWith("§"))
            {
                var prgrm = new RPLProgram();
                prgrm.Value = Regex.Replace(input, "§", "");
                stack.Push(prgrm);
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
