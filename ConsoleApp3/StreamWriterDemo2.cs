using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp3
{
    public class StreamWriter2Demo
    {
        static void Main()
        {
            StreamWriter writer = new StreamWriter(@"E:\Trainings\Data.txt"); ;
            writer.WriteLine("This is first line");
            writer.WriteLine("This is seond line");
            writer.Close();

            StreamReader reader = new StreamReader(@"E:\Trainings\Data.txt");
            Console.WriteLine(reader.ReadToEnd()) ;
            reader.Close();

        }
    }
}
