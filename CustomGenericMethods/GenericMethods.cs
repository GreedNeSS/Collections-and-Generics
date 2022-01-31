using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    public static class GenericMethods
    {
        public static void Swap<T>(ref T arg1, ref T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine($"Base class of {typeof(T)} is: {typeof(T).BaseType}");
        }
    }
}
