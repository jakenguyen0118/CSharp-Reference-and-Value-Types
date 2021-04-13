using System;

namespace CSharp_Reference_and_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type
            // does not affect each other in memory
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // reference type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            // first element of array1 will change to 0
            // when copied they are referencing from the same memory, and not copying the value like value types
            // any changes made for array1 or array2 will change both
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        }
    }
}
