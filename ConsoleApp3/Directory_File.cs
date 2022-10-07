using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    class Directory_File
    {
        static void Main()
        {
            {
                Console.WriteLine(Directory.GetCurrentDirectory().ToString());
                string[] dirs = Directory.GetDirectories(@"E:\Trainings");
 foreach(string directory in dirs)
                    Console.WriteLine(directory.ToString());
                Directory.CreateDirectory(@"E:\newdir");


            }
        }

    }
}
