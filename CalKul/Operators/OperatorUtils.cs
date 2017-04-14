using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalKul.Operators
{
    public static class OperatorUtils
    {
        public static void CheckArgs(Stack<object> args, IOperator op)
        {
            CheckNumberOfArguments(args, op.NumberOfArguments);
        }

        internal static bool IsNumeric(Stack<object> args, int numberOfArguments)
        {
            CheckNumberOfArguments(args, numberOfArguments);
            return IsOfType(args, numberOfArguments, typeof(double));
        }

        internal static bool IsString(Stack<object> args, int numberOfArguments)
        {
            CheckNumberOfArguments(args, numberOfArguments);
            return IsOfType(args, numberOfArguments, typeof(string));
        }

        internal static bool CheckIsSupportedTypes(Stack<object> args, int numberOfArguments, List<List<Type>> supportedTypes)
        {
            bool isSupported = false;
            foreach (var typeList in supportedTypes)
            {
                bool allSupported = true;
                var stackArr = args.ToArray();
                for (int i=0;i< numberOfArguments; i++)
                {
                    if (stackArr[i].GetType() != typeList[i])
                    {
                        allSupported = false;
                    }
                }
                if (allSupported)
                {
                    isSupported = true;
                }
            }
            return isSupported;
        }

        internal static bool IsOfType(Stack<object> args, int numberOfArguments, Type type)
        {
            bool allIsTypable = true;
            var stackArr = args.ToArray();
            for (int i = 0; i < numberOfArguments; i++)
            {
                if (stackArr[i].GetType() != type)
                 {
                    allIsTypable = false;
                }
            }
            return allIsTypable;
        }

        internal static void CheckNumberOfArguments(Stack<object> args, int numberOfArguments)
        {
            if (args.Count < numberOfArguments)
            {
                throw new ArgumentException("Wrong number of arguments");
            }
        }

    }
}
