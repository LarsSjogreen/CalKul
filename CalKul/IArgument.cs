using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    interface IArgument
    {
        ArgumentType Type { get; }
        double NumericValue { get; }
        string StringValue { get; }
    }

    enum ArgumentType
    {
        Float,
        Int,
        String
    }
}
