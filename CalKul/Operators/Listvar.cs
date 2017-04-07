using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    class Listvar : IOperator
    {
        private IVariableStorage _storage;

        public Listvar(IVariableStorage storage)
        {
            _storage = storage;
        }

        public int NumberOfArguments
        {
            get
            {
                return 0;
            }
        }

        public string OperandName
        {
            get
            {
                return "listvar";
            }
        }

        public object Do(Stack<object> args)
        {
            foreach (var variable in _storage.GetAllKeys())
            {
                Console.WriteLine(variable);
            }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            return null;
        }
    }
}
