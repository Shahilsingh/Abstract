using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class university
    {
       
        public abstract void BTech();
        public abstract void MBA();
    }

       public class GBTU : university
    {
        public override void BTech()
        {
            Console.WriteLine("GBTU BTech Fee 50000/-");
        }
        public override void MBA()
        {
            Console.WriteLine("GBTU MBA Fee 100000/-");
        }
    }
    public class MTU : university
    {
        public override void BTech()
        {
            Console.WriteLine("MTU BTech Fee 40000/-");
        }
        public override void MBA()
        {
            Console.WriteLine("MTU MBA Fee 800000/-");
        }
    }
    public class AbstractProgram
    {
        static void Main(string[] args)
        {
            GBTU g = new GBTU();
            g.BTech();
            g.MBA();
            MTU m = new MTU();
            m.BTech();
            m.MBA();
            Console.ReadLine();
        }
    }
}
