using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "HELLO WORLD";
            string hello2 = "HELLO WORLD";

            var x = string.Intern("HELLO WORLD");
            var b = object.ReferenceEquals(hello, x);

            // this is master

            // this is feature

            Console.WriteLine(hello);
           // String.Intern()
        }
    }
}
