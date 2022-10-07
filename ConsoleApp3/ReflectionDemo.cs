using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApp3
{
    class ReflectionDemo
    {
        static void Main()
        {
            // To give all custom attributes
            MemberInfo info = typeof(Developer);
            object[] attributes = info.GetCustomAttributes(true);
            for(int i = 0;i<attributes.Length;i++)
                Console.WriteLine(attributes[i]);

            // to give info abt the custom attribute
            Type type = typeof(Developer);
            foreach(Object attribute in type.GetCustomAttributes(false))
            {
                CustomAttribute att = (CustomAttribute)attribute;
                if(att!=null)

                {
                    Console.WriteLine("Author is " + att.AuthorName);
                    Console.WriteLine("Description is " + att.Description);
                    Console.WriteLine("Creation Date is " + att.DateOfCreation);

                } 
            }

            // get attr info for methods
            foreach (var member in type.GetMembers())
            { 
                if(member.MemberType == MemberTypes.Method)
                {
                    Console.WriteLine(member);
                }
            
            }
               foreach(MethodInfo methods in type.GetMethods())
            {
                //Console.WriteLine("method names " + methods);
                if (!methods.ToString().Contains("System"))
                {
                   

                    foreach (Attribute attribute in methods.GetCustomAttributes(false))
                    {
                        CustomAttribute att = (CustomAttribute)attribute;
                        if (att != null)

                        {
                            Console.WriteLine("Author is " + att.AuthorName);
                            Console.WriteLine("Description is " + att.Description);
                            Console.WriteLine("Creation Date is " + att.DateOfCreation);

                        }
                    }
                }

            }


        }
    }
}
