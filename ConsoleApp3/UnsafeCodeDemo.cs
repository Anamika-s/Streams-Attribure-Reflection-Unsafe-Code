using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class UnsafeCodeDemo
    {
       static void Main()
        {
            // Declare code block as unsafe as we are using pointers
            unsafe
            {
                int x = 10;
                int* ptr;
                ptr = &x;
                Console.WriteLine("Indise unsafe code block");
                Console.WriteLine("Valu of x " + *ptr); ;
            }
            Console.WriteLine("Outsie unsafe nblock ");
            
        }
    }
}
