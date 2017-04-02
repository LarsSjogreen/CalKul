using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    public interface IOperator
    {
        int NumberOfArguments { get; }
        string OperandName { get; }
        object Do(Stack<object> args);
//        void Validate(Stack<object> args);
//      SupportedDatatypes...
    }
}
