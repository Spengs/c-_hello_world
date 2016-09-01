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

// cmdline1.cs
// arguments: A B C
using System;

public class CommandLine
{
   public static void Main(string[] args)
   {
       // The Length property is used to obtain the length of the array. 
       // Notice that Length is a read-only property:
       Console.WriteLine("Number of command line parameters = {0}",
          args.Length);
       for(int i = 0; i < args.Length; i++)
       {
           Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
       }
   }
}
