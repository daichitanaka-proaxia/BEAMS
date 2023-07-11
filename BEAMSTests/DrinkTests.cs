using BEAMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMSTests
{
    [TestClass]
    public class DrinkTests
    {
        [TestMethod]
        public void ConfirmGetInfo()
        {
            var drink1 = new Drink("りんごジュース", 172, "2023年7月度ベストセラー",160);
            var expected1 = "【飲料品】りんごジュース 172円 160ml 2023年7月度ベストセラー ★軽率減税適用品★";
            Assert.AreEqual(expected1, drink1.GetInfo());

            var drink2 = new Drink("緑茶", 165, "サントリー", 2000);
            var expected2 = "【飲料品】緑茶 165円 2,000ml サントリー ★軽率減税適用品★";
            Assert.AreEqual(expected2, drink2.GetInfo());
        }
    }
}
