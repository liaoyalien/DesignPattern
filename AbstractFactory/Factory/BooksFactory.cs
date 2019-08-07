using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class BooksFactory : IFactory
    {
        public AbstractOrder CreateOrder()
        {
            return new BooksOrder();
        }
        public AbstractInvoice CreateInvoice()
        {
            return new BooksInvoice();
        }
    }
}