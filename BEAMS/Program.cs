namespace BEAMS
{
    public class Project
    {
        public static void Main(string[] args)
        {
            var products = new List<Product>();

            var product1 = new Product("NIKE AF-1", 13200,"最大購入点数：1人1点まで");
            var food1 = new Food("クリームデニッシュ（チョコレート）",540,"クリスマス限定品",650);
            var drink1 = new Drink("綾鷹", 123, "コカ・コーラ社", 500);

            products.Add(product1);
            products.Add(food1);
            products.Add(drink1);

            products.ForEach(product => Console.WriteLine(product.GetInfo()));
        }
    }
}