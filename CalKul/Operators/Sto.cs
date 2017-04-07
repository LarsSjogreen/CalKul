using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public class Sto : IOperator
    {
        IVariableStorage _storage;
        public Sto(IVariableStorage storage)
        {
            _storage = storage;
        }

        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "sto"; }
        }

        public object Do(Stack<object> args)
        {
            _storage.SetValue((string)args.Pop(), args.Pop());
            return null;
        }
    }
}
