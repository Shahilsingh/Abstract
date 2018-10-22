using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class MyAbs
    {
        public void NonAbMethod()
        {
            Console.WriteLine("Non-Abstract Method");
        }
    }

    class O : MyAbs
    {
    }

    class D
    {
        static void Main(string[] args)
        {
            
            O o = new O();
            o.NonAbMethod();
            Console.ReadLine();
        }
    }
}

