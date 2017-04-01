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
        double Do(Stack<double> args);
//        void Validate(Stack<double> args);
    }
}
