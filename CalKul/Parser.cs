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

        public void WriteStack(Stack<double> stack)
        {
            int numRows = 8;
            int counter = numRows;

            Console.Clear();
            var showLevels = stack.Count;
            if (showLevels > numRows)
            {
                showLevels = numRows;
            }

            var stackView = stack.Take(showLevels).Reverse();
            for (var i = 0; i < (numRows - showLevels); i++)
            {
                Console.WriteLine(counter--.ToString() + ": ");
            }
            foreach (var stackItem in stackView)
            {
                Console.WriteLine(counter--.ToString() + ": " + stackItem.ToString());
            }
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
