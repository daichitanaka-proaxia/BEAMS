using BEAMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMSTests
{
    [TestClass]
    public class FoodTests
    {
        [TestMethod]
        public void ConfirmGetInfo()
        {
            var food1 = new Food("煎りピーナッツ", 1350, "福島県産", 972);
            var expected1 = "【食品】煎りピーナッツ 1,350円 972kcal 福島県産 ★軽率減税適用品★";
            Assert.AreEqual(expected1, food1.GetInfo());
        }
    }
}
