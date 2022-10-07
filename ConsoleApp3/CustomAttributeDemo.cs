using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class CustomAttribute : Attribute
    {
        string authorName;
        string description;
        string dateOfCreation;
        public string AuthorName
        {
            get
            {
                return authorName;
            }

            set
            {
                authorName = value;
            }

        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string DateOfCreation
        {
            get
            {
                return dateOfCreation;
            }
            set
            {
                dateOfCreation = value;
            }

        }
    }
   
    [Custom(AuthorName ="Deepak Kumar", DateOfCreation ="12/12/2019", Description ="This is a class for developers")]
        class Developer
        {
            public void Get()
            {
                Console.WriteLine("Get");
            }
        [Custom(AuthorName = "Arun Kumar", DateOfCreation = "12/12/2021", Description = "This is a method added for developers")]

        public void Display()
            {
                Console.WriteLine("Display");
            }

        }

    class Program
    {
        static void Main()
        {
            Developer developer1 = new Developer();
            developer1.Get();
            developer1.Display();
        }
    }
    }