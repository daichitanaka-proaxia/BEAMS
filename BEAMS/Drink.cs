using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMS
{
    public class Drink: Product
    {
        public int Amount {  get; }
        public Drink(string name, int price, string memo,int amount): base(name,price,memo)
        {
            Amount = amount;
        }

        public override String GetInfo()
        {
            return $"【飲料品】{Name} {Extension.Deliminate(Price)}円 {Extension.Deliminate(Amount)}ml {Memo} ★軽率減税適用品★";
        }
    }
}