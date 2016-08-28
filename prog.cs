using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            Console.Write("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
        }
        
    }
}
