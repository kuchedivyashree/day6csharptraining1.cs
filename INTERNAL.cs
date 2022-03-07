using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class InternalTest
    {
        internal string name = "pavan";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
            Console.WriteLine("Hello" + internalTest.name);
            internalTest.Msg("peter");
            Console.ReadLine();
        }

    }
}
