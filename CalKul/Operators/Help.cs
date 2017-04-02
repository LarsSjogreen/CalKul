using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public class Help : IOperator
    {
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "help"; }
        }

        public object Do(Stack<object> args)
        {
            Console.WriteLine("Available operators:");
            Console.WriteLine("");
            IEnumerable<IOperator> operators = new List<IOperator>();
            operators = from t in Assembly.GetExecutingAssembly().GetTypes()
                                            where t.GetInterfaces().Contains(typeof(IOperator))
                                                && t.GetConstructor(Type.EmptyTypes) != null
                                            select Activator.CreateInstance(t) as IOperator;
            foreach (var op in operators)
            {
                Console.WriteLine(op.OperandName);
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return double.MinValue;
        }
    }
}
