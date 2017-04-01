using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    class Program
    {
        static Parser parser;

        static void Main(string[] args)
        {
            Stack<double> doubleStack = new Stack<double>();
            string input = "";

            parser = new Parser();
            AutoregisterOperators();

            parser.WriteStack(doubleStack);
            while ((input = Console.ReadLine()) != "quit")
            {
                try
                {
                    parser.ParseDo(input, doubleStack);
                    parser.WriteStack(doubleStack);
                } catch (Exception exp)
                {
                    Console.WriteLine("Error: " + exp.Message);
                }
            }
        }

        static void AutoregisterOperators()
        {
            parser.Operators = new List<IOperator>();

            var operators = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IOperator))
                                && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IOperator;

            foreach (var op in operators)
            {
                parser.Operators.Add(op);
            }
        }
    }
}
