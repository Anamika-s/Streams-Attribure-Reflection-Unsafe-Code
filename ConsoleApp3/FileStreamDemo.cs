using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp3
{
    class FileStreamDemo
    {
        static FileStream fs = null;
        static StreamWriter writer = null;
        static StreamReader reader = null;
        static int MainMenu()
        {
            int choice;
            Console.WriteLine("1. Create New File");
            Console.WriteLine("2. Read from File");
            Console.WriteLine("3. Append to a file");
            Console.WriteLine("4. Delete all contents");
            Console.WriteLine("Enter your Choice");
            choice = Byte.Parse(Console.ReadLine());
            return choice;

        }
        static void Main()
        {
            string ch = "y";
            while (ch.ToLower() == "y")
            {
                int choice = MainMenu();
                switch (choice)
                {
                    case 1:
                        {
                            CreateFile();
                            break;
                        }

                    case 2:
                        {
                            AppendFile();
                            break;
                        }

                    case 3:
                        {
                            ReadContents();
                            break;

                        }
                    case 4:
                        {
                            DeleteContents();
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice");
                            break;
                        }
                }
                Console.WriteLine("Want to repeat again");
                ch = Console.ReadLine();
            }

        }
        //[Obsolete]
        [Obsolete("Use NewCreateFile Method")]
        //[Obsolete("Use NewCreateFile Method", true)]
        static void CreateFile()
        {

            try
            {
                fs = new FileStream(@"E:\Trainings\Data100.txt", FileMode.CreateNew, FileAccess.Write);
                writer = new StreamWriter(fs);

                string ch = "y";
                while (ch.ToLower() == "y")
                {
                    Console.WriteLine("Enter name");
                    string value = Console.ReadLine();
                    writer.WriteLine(value);
                    Console.WriteLine("Want to enter more data");
                    ch = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
        }

        static void NewCreateFile()
        {

            try
            {
                fs = new FileStream(@"E:\Trainings\Data100.txt", FileMode.CreateNew, FileAccess.Write);
                writer = new StreamWriter(fs);

                string ch = "y";
                while (ch.ToLower() == "y")
                {
                    Console.WriteLine("Enter name");
                    string value = Console.ReadLine();
                    writer.WriteLine(value);
                    Console.WriteLine("Want to enter more data");
                    ch = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fs.Close();
            }
        }

        static void AppendFile()
        {

            fs = new FileStream(@"E:\Trainings\Data100.txt", FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(fs);

            string ch = "y";
            while (ch.ToLower() == "y")
            {
                Console.WriteLine("Enter name");
                string value = Console.ReadLine();
                writer.WriteLine(value);
                Console.WriteLine("Want to enter more data");
                ch = Console.ReadLine();
            }
            writer.Close();
            fs.Close();

        }

        static void ReadContents()
        {
            fs = new FileStream(@"E:\Trainings\Data100.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(fs);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            fs.Close();

        }
        static void DeleteContents()
        {
            //fs = new FileStream(@"E:\Trainings\Data100.txt", FileMode.Truncate);
            //fs.Close();
            File.Delete(@"E:\Trainings\Data100.txt");


        }
    }
}
