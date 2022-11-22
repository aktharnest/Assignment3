using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Bank
    {
        public virtual float getRateOfInterest() { return 0; }
    }
    class SBI : Bank
    {
        public override float getRateOfInterest() { return 8.4f; }
    }
    class ICICI : Bank
    {
        public override float getRateOfInterest() { return 7.3f; }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Bank b=new Bank();
            b = new SBI();
            Console.WriteLine("SBI Rate of Interest  = "+b.getRateOfInterest());
            b = new ICICI();
            Console.WriteLine("ICICI Rate of Interest = " + b.getRateOfInterest());
            Console.Read();
        }
    }
}
