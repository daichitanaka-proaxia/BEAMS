using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMS
{
    public class Product
    {
        public static int Count = 0;
        public String Name { get; }
        public int Price { get; }
        public String Memo { get; }
        public Product(string name, int price, string memo)
        {
            Count += 1;
            Name = name;
            Price = price;
            Memo = memo;
        }

        public virtual String GetInfo()
        {
            return $"{Name} {Deliminate(Price)} 円 {Memo}";
        }

        protected String Deliminate(int value)
        {
            return String.Format("{0:#,0}", value);
        }
    }
}
