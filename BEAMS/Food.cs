using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMS
{
    public class Food : Product
    {
        public int Calorie { get; }
        public Food(string name, int price, string memo,int calorie) : base(name, price, memo)
        {
            Calorie = calorie;
        }

        public override String GetInfo()
        {
            return $"【食品】{Name} {Deliminate(Price)}円 {Deliminate(Calorie)}kcal {Memo} ★軽率減税適用品★";
        }
    }
}
