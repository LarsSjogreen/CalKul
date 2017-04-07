using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using CalKul.Operators;

namespace CalKul
{
    class Program
    {
        static Parser parser;
        static IUserInterface userInterface;
        static IVariableStorage currentStorage;
        static IKernel kernel;

        static void Main(string[] args)
        {
            kernel = new StandardKernel(new CalculatorModule());
            Stack<object> objectStack = new Stack<object>();
            string input = "";

            currentStorage = kernel.Get<IVariableStorage>();
            userInterface = kernel.Get<IUserInterface>();

            parser = new Parser(currentStorage);

            AutoregisterOperators();

            userInterface.WriteStack(objectStack);
            while ((input = Console.ReadLine()) != "quit")
            {
                try
                {
                    parser.ParseDo(input, objectStack);
                    userInterface.WriteStack(objectStack);
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

            var opList = operators.ToList<IOperator>();
            opList.Add(new Sto(currentStorage));
            opList.Add(new Listvar(currentStorage));

            foreach (var op in opList)
            {
                parser.Operators.Add(op);
            }
        }
    }
}
