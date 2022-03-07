using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class pig:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine(" the pig says:wee wee");

        }
    }
    class Progr
    {
        static void Main(string[] args)
        {
            pig myPig = new pig();
            myPig.animalSound();
            myPig.sleep();
            Console.ReadLine();
        }
    }
}
