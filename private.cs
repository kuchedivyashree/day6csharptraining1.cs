using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program1
    {
        private string name = "deepa";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
        static void Main(string[] args)
        {
            Program1 program1 = new Program1();
            Console.WriteLine("Hello" + program1.name);
            program1.Msg("pinky");
            Console.ReadLine();
        }


    }
}
