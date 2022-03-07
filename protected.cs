using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    class ProtectedTest
    {
        protected string name = "ajay";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class Progm:ProtectedTest
    {
        static void Main(string[] args)
        {
            Progm progm = new Progm();
            Console.WriteLine("Hello" +progm.name);
            progm.Msg("shivani");
            Console.ReadLine();
        }
    }
}
    



