using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class ConsoleUserInterface : IUserInterface
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void WriteStack(Stack<double> stack)
        {
            int numRows = 8;
            int counter = numRows;

            Clear();
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

    }
}
