using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal2
    {
    public abstract void eat();
        public void sound()
        {
            Console.WriteLine("dog can sound");
        }
    }
    class dog : Animal2
    {


        public override void eat()
        {
            Console.WriteLine("dog can eat");
        }
        static void Main()
        {
            dog i = new dog();
            i.eat();
            i.sound();

            Console.ReadLine();

         }
     }
}       
