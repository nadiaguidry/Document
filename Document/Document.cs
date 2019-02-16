using System;


namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document");
            Console.WriteLine(" ");

            string testString;
            Console.Write("Please enter the name of the .txt document: ");
            testString = Console.ReadLine();
            Console.WriteLine("You entered '{0}.txt'", testString);
            Console.WriteLine(" ");
            string test;
            Console.Write("Please enter the content that is needed in the document: ");
            test = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", test);
            Console.WriteLine(" ");

            if (testString == null & test == null)
            {
                Console.WriteLine("Exception Occurence");
            }
            else
            {

                Console.WriteLine("{0}.txt was successfully saved. The document contains 10 characters.", testString);
            }
            }
        }
    }

