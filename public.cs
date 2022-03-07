using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class PublicTest
    {
        public string name = "divya";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class Program
    {


        static void main(string[] args)
        {
            PublicTest publicTest = new PublicTest();
            Console.WriteLine("hello" + publicTest.name);
            publicTest.Msg("sushmita");
            Console.ReadLine();
        }
    }



}
