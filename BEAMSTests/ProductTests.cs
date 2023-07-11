using BEAMS;

namespace BEAMSTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ConfirmGetInfo()
        {
            var product1 = new Product("スニーカー",13200,"※人気商品のため購入後の返品不可");
            var expected1 = "スニーカー 13,200 円 ※人気商品のため購入後の返品不可";
            Assert.AreEqual(expected1, product1.GetInfo());

            var product2 = new Product("チノパン", 13200, "ビームスの百名品");
            var expected2 = "チノパン 13,200 円 ビームスの百名品";
            Assert.AreEqual(expected2, product2.GetInfo());
        }
    }
}