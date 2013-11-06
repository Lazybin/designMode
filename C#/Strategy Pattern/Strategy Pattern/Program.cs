using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            Strategy st;
            Contentxt ct = new Contentxt();
           
            st= ct.getStrategy(c);
            st.Price = Convert.ToDouble(a);
            st.Count = Convert.ToDouble(b);
            Console.WriteLine("result:" + st.getPrice().ToString());
            c = Console.ReadLine();
        }
    }
    class Contentxt
    {
        private Strategy st;
        public Strategy getStrategy(string moshi)
        {
            switch (moshi)
            {
                case "putong":
                    st = new NormalStrategy();
                    break;
                case "0.8":
                    st = new da8zheStrategy();
                    break;
                default:
                    st = new NormalStrategy();
                    break;
            }
            return st;
        }
    }
    class Strategy
    {
        private double price = 0;
        private double count = 0;
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public double Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
        public virtual double getPrice()
        {
            double result = Price * Count;
            return result;
        }
    }
    class NormalStrategy : Strategy
    {
        public override double getPrice()
        {
            double result = Price * Count;
            return result;
        }
    }
    class da8zheStrategy : Strategy
    {
        public override double getPrice()
        {
            double result = Price * Count*0.8;
            return result;
        }
    }
}
