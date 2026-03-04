using System;

// README.md를 읽고 코드를 작성하세요.


Console.WriteLine("=== 상품 카탈로그 ===");
Product[] products = new Product[]
{
    new Electronics(),
    new Clothing(),
    new Food ()
};
foreach (Product product in products)
{
    Console.WriteLine(product.ToString());
    product.GetDescription();
}