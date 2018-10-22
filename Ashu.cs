using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class BaseProduct
    {
        // define properties
        protected float Price;
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float Rate { get; set; }
        public float Tax { get; set; }
        public abstract float CalculatePrice();
    };

    // First derive Non Taxable class first
    class NonTaxableProducts : BaseProduct
    {
        public void AddProduct()
        {
            Console.Write("Enter non-taxable product name : ");
            ProductName = Console.ReadLine();

            Console.Write("Enter Qty: ");
            Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Rate: ");
            Rate = float.Parse(Console.ReadLine());
        }
        public override float CalculatePrice()
        {
            return Price = Quantity * Rate;
        }
    }

    // Secondly derive Taxable class
    public class TaxableProducts : BaseProduct
    {
        public void AddProduct()
        {
            Console.Write("Enter taxable product name : ");
            ProductName = Console.ReadLine();

            Console.Write("Enter Qty: ");
            Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Rate: ");
            Rate = float.Parse(Console.ReadLine());

            Console.Write("Enter applicable Tax percentage: ");
            Tax = float.Parse(Console.ReadLine());
        }

        public override float CalculatePrice()
        {
            return Price = Quantity * Rate + ((Quantity * Rate) * Tax / 100);
        }
    }

    class Ashu
    {
        //  Passing Abstract class as variable
        public static void Calculations(BaseProduct BP)
        {
            Console.WriteLine("Calculated Price : {0}", BP.CalculatePrice());
        }

        static void Main(string[] args)
        {
            // instance of non taxable product
            NonTaxableProducts ntp = new NonTaxableProducts();
            ntp.AddProduct();
            Calculations(ntp);
            Console.ReadLine();

            // instance of taxable product
            TaxableProducts tp = new TaxableProducts();
            tp.AddProduct();
            Calculations(tp);
            Console.ReadLine();
        }
    }
}
