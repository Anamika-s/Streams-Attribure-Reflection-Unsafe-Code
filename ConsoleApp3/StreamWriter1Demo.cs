using System;
using System.IO;

namespace ConsoleApp3
{
    class StreamWriter1Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello"); // It writes on standard Output Device
            //string name = Console.ReadLine();
            // It reads from standard Input Device 
            StringWriter writer = new StringWriter();
            writer.WriteLine("This is first line");
            writer.WriteLine("This is seond line");

            StringReader reader = new StringReader(writer.ToString());

            //Console.WriteLine(reader.ReadToEnd());

            //string read = reader.ReadLine();
            //while(read!=null)
            //{
            //    Console.WriteLine(read);
            //    read = reader.ReadLine();
            //}

            
            while(reader.Peek()>0)
            {
                Console.WriteLine((char)reader.Read());
            }

           }
    }
}
