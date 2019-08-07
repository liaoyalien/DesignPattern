using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public interface IFactory
    {
        AbstractOrder CreateOrder();
        AbstractInvoice CreateInvoice();
    }
}