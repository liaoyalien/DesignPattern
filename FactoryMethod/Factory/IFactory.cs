using FactoryMethod.Enum;
using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    public interface IFactory
    {
        AbstractOrder CreateOrder();
    }
}