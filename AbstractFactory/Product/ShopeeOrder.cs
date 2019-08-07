using System;

namespace AbstractFactory.Product
{
    public class ShopeeOrder : AbstractOrder
    {
        public override void Upload()
        {
            Console.WriteLine("Shopee Order Uploaded");
        }
    }
}