using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _7_7_15_ExperIT_StringLab1
{
    class Program
    {
   
        static void Main(string[] args)
        {
        
            for (int x = args.Length-1; x > 0; x--)
            {
                Console.Write(args[x]);
                Console.Write(" ");
            }

            Console.WriteLine(args[0]);
            Console.ReadLine();
        }
    }
} 