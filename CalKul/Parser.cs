﻿using System;
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

                foreach (var variable in _storage.GetAllKeys())
                {
                    if (input == variable)
                    {
                        Eval(_storage.GetValue(variable), stack);
                    }
                }
            }
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
