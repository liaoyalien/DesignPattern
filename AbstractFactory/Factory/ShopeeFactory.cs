using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class ShopeeFactory : IFactory
    {
        public AbstractOrder CreateOrder()
        {
            return new ShopeeOrder();
        }

        public AbstractInvoice CreateInvoice()
        {
            return new ShopeeInvoice();
        }
    }
}