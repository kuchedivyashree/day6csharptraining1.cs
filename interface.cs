using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    interface IAnimal
    {
        void animalSound();
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("the pig says:wee wee");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            Console.ReadLine();
        }
    }
}
