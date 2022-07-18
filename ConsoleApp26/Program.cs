using System;
using System.Collections.Generic;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args) 
        {
            var List = new List<KeyValuePair<string, int>>();
            List.Add(new KeyValuePair<string, int>("Bob", 27));
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            string Foo = List.ToString();
            Console.WriteLine(Foo);
            var Boys  = new List<string>();
            Boys.Add("vasyl, oleg, victor, dmitro");
            Boys.ForEach(Console.WriteLine);
            string[] Array = new string[] { "nitro", "vitto" };
            foreach (var item in Array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("hello, guys");
        }

    
    }
}
