# BEAMS [![.NET](https://github.com/daichitanaka-proaxia/BEAMS/actions/workflows/dotnet.yml/badge.svg)](https://github.com/daichitanaka-proaxia/BEAMS/actions/workflows/dotnet.yml)

セレクトショップを題材に、テストコードの書き方を学ぶ

## テストコードの書き方
```csharp
namespace BEAMSTests
{
    [TestClass]
    public class ExtensionTests
    {
        [TestMethod]
        public void ConfirmDeliminate()
        {
            var expected1 = "999";
            var result1 = Extension.Deliminate(999);
            Assert.AreEqual(expected1, result1);

            var expected2 = "1,000";
            var result2 = Extension.Deliminate(1000);
            Assert.AreEqual(expected2, result2);
        }
    }
}
```

## テスト駆動開発（TDD）の進め方
### 1. 先にテストコードを書く

```csharp
using System.Threading.Tasks;

namespace BEAMSTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ConfirmGetInfo()
        {
            var product1 = new Product("スニーカー", 13200, "※人気商品のため購入後の返品不可");
            var expected1 = "スニーカー 13,200 円 ※人気商品のため購入後の返品不可";
            Assert.AreEqual(expected1, product1.GetInfo());
        }
    }
}
```

### 2. ビルドが通るようにコードを実装する・テストが失敗するコードを書く
```csharp
namespace BEAMS
{
    public class Product
    {
        public Product(){}

        public virtual String GetInfo()
        {
            return "";
        }
    }
}

```

### 3. テストを実行し、失敗することを確認する


### 4. テストが成功するコードを書く
```csharp
namespace BEAMS
{
    public class Product
    {
        public Product(){}

        public virtual String GetInfo()
        {
            return "スニーカー 13,200 円 ※人気商品のため購入後の返品不可";
        }
    }
}

```


### 5. テストを実行し、成功することを確認する


### 6. テストの条件を追加する
```csharp
namespace BEAMSTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ConfirmGetInfo()
        {
            var product1 = new Product("スニーカー", 13200, "※人気商品のため購入後の返品不可");
            var expected1 = "スニーカー 13,200 円 ※人気商品のため購入後の返品不可";
            Assert.AreEqual(expected1, product1.GetInfo());

            var product2 = new Product("チノパン", 13200, "ビームスの百名品");
            var expected2 = "チノパン 13,200 円 ビームスの百名品";
            Assert.AreEqual(expected2, product2.GetInfo());
        }
    }
}
```

### 7. テストを実行し、失敗することを確認する

### 8. テストが成功するコードを書く
```csharp
namespace BEAMS
{
    public class Product
    {
        public String Name { get; }
        public int Price { get; }
        public String Memo { get; }
        public Product(string name, int price, string memo)
        {
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
```