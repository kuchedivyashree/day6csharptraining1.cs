using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class InterTest
    {
        protected internal string name = "kasturi";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class pr
    {
        static void Main(string[] args)
        {
            InterTest interTest = new InterTest();
            Console.WriteLine("Hello" + interTest.name);
            interTest.Msg("priya");
            Console.ReadLine();
        }
    }
}
