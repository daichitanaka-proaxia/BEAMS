using BEAMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAMSTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ConfirmGetProducts()
        {
            var products = Project.GetProducts();
            var expected1 = "NIKE AF-1 13,200 円 最大購入点数：1人1点まで";
            var result1 = products[0].GetInfo();
            Assert.AreEqual(expected1, result1);

            var expected2 = "【食品】クリームデニッシュ（チョコレート） 540円 650kcal クリスマス限定品 ★軽率減税適用品★";
            var result2 = products[1].GetInfo();
            Assert.AreEqual(expected2, result2);

            var expected3 = "【飲料品】綾鷹 123円 500ml コカ・コーラ社 ★軽率減税適用品★";
            var result3 = products[2].GetInfo();
            Assert.AreEqual(expected3, result3);
        }
    }
}
