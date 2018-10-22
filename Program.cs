using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
  public abstract class Program
    {
       
    public abstract void draw();
    }
    public class Rectangle : Program
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Program
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Program s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadLine();
        }
    }
}
