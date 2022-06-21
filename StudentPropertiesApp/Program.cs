using StudentPropertiesApp.Model;
using System;

namespace StudentPropertiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "shyam";
            s1.Roll = 50;

            Console.WriteLine("Name of student is : " + s1.Name);
            Console.WriteLine("roll no is " + s1.Roll);
            Console.WriteLine("Total fee :" + s1.TotalFee);
            Console.WriteLine("Remaining fee :" + s1.RemainingFee);
            s1.PayFees(20000);
            Console.WriteLine("Now fees are paid , the remaing fee is : " + s1.RemainingFee);
            s1.PayFees(40000);
            Console.WriteLine("Now fees are paid , the remaing fee is : " + s1.RemainingFee);
            s1.PayFees(60000);
            Console.WriteLine("Now fees are paid , the remaing fee is : " + s1.RemainingFee);

        }
    }
}
