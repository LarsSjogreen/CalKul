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

        public void WriteStack(Stack<object> stack)
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
                Console.WriteLine(counter--.ToString() + ": :");
            }
            foreach (var stackItem in stackView)
            {
                string typ = stackItem.GetType().ToString();
                typ = typ.Remove(0, 7);
                typ = typ.ToLower();
                typ = typ.Remove(1);
                Console.WriteLine(counter--.ToString() + ":" + typ + ": " + stackItem.ToString());
            }
            Console.WriteLine("-----------------------------------");
        }

    }
}
