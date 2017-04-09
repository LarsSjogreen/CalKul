using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class ConsoleUserInterface : IUserInterface, IConfigurable
    {
        IConfigurator _configurator;
        int showDatatypes;
        int showLineNumbers;
        int stackRows;

        public ConsoleUserInterface(IConfigurator configurator)
        {
            _configurator = configurator;
            _configurator.Subscribe(this.UpdateConfigs, "windowheight");
            _configurator.Subscribe(this.UpdateConfigs, "windowwidth");
            _configurator.Subscribe(this.UpdateConfigs, "showdatatypes");
            _configurator.Subscribe(this.UpdateConfigs, "showlinenumbers");
            _configurator.Subscribe(this.UpdateConfigs, "stackrows");
            UpdateConfigs();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void UpdateConfigs()
        {
            int wid = _configurator.ReadConfig("windowwidth", 40);
            Console.WindowWidth = wid;
            int heig = _configurator.ReadConfig("windowheight", 20);
            Console.WindowHeight = heig;
            showDatatypes = _configurator.ReadConfig("showdatatypes", 1);
            showLineNumbers = _configurator.ReadConfig("showlinenumbers", 1);
            stackRows = _configurator.ReadConfig("stackrows", 10);
        }

        public void WriteStack(Stack<object> stack)
        {
            int counter = stackRows;

            Clear();
            var showLevels = stack.Count;
            if (showLevels > stackRows)
            {
                showLevels = stackRows;
            }

            var stackView = stack.Take(showLevels).Reverse();
            for (var i = 0; i < (stackRows - showLevels); i++)
            {
                if (showLineNumbers == 1 && showDatatypes == 1)
                {
                    if (stackRows > 9 && counter < 10) { Console.Write(" "); }
                    Console.WriteLine(counter--.ToString() + ": :");
                }
                else if (showLineNumbers == 0 && showDatatypes == 1)
                {
                    Console.WriteLine(" :");
                }
                else if (showLineNumbers == 1 && showDatatypes == 0)
                {
                    if (stackRows > 9 && counter < 10) { Console.Write(" "); }
                    Console.WriteLine(counter--.ToString() + ":");
                }
                else
                {
                    Console.WriteLine(":");
                }
            }
            foreach (var stackItem in stackView)
            {
                string typ = stackItem.GetType().ToString();
                typ = typ.Remove(0, 7);
                typ = typ.ToLower();
                typ = typ.Remove(1);
                if (showLineNumbers == 1 && showDatatypes == 1)
                {
                    if (stackRows > 9 && counter < 10) { Console.Write(" "); }
                    Console.WriteLine(counter--.ToString() + ":" + typ + ": " + stackItem.ToString());
                }
                else if (showLineNumbers == 0 && showDatatypes == 1)
                {
                    Console.WriteLine(typ + ": " + stackItem.ToString());
                }
                else if (showLineNumbers == 1 && showDatatypes == 0)
                {
                    if (stackRows > 9 && counter < 10) { Console.Write(" "); }
                    Console.WriteLine(counter--.ToString() + ": " + stackItem.ToString());
                }
                else if (showLineNumbers == 0 && showDatatypes == 0)
                {
                    Console.WriteLine(": " + stackItem.ToString());
                }
            }
            Console.WriteLine("-----------------------------------");
        }

    }
}
