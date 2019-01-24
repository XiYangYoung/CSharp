#define DEBUG
using System;
using System.Diagnostics;
namespace Project
{
    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void Message(String msg)
        {
            System.Console.WriteLine(msg);

        }
    }

    class Test
    {
        static void function1()
        {
            MyClass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            MyClass.Message("In Function 2.");
        }
        public static void Main(string[] args)
        {
            MyClass.Message("In Main function.");
            function1();
        }
    }
}