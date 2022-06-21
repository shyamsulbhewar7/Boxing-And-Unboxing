using System;

namespace POC_Boxing_and_Unboxing_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The process of converting a Value Type variable (char, int etc.)");
            Console.WriteLine("to a Reference Type variable (object) is called Boxing.");
            int num = 2020;
            // boxing
            object obj = num;
            Console.WriteLine("Object - type value of obj is : {0}", obj);
            // value of num to be change
            num = 100;
            Console.WriteLine("Value - type value of num is : {0}", num);
            Console.WriteLine("Object - type value of obj is : {0}\n\n", obj);

            Console.WriteLine("The process of converting a Reference Type variable ");
            Console.WriteLine("into a Value Type variable is known as Unboxing.");

            int num1 = 23;
            // boxing
            object obj1 = num1;
            // unboxing
            int i = (int)obj1;
            // Display result
            Console.WriteLine("Value of ob object is : " + obj1);
            Console.WriteLine("Value of i is : " + i);
        }
    }
}
