using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul
{
    interface IUserInterface
    {
        void WriteStack(Stack<double> stack);
        void Clear();
    }
}
