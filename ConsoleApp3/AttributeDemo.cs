#define C2

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp3
{
    // Conditional > 
    class AttributeDemo
    {
        [Conditional("C1")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

    }

    class Test
    {
        static void function1()
        {
            AttributeDemo.Message("Calling from function1");
            function2();

        }
        static void function2()
        {
            AttributeDemo.Message("Calling from function2");


        }

static void Main()
        {
            AttributeDemo.Message("In Main function");
            function1();
        }
    }
}
