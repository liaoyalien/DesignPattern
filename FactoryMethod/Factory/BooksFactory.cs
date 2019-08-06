using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Enum;
using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    public class BooksFactory : IFactory
    {
        public AbstractOrder CreateOrder()
        {
            return new BooksOrder();
        }
    }
}