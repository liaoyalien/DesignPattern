using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Enum;
using FactoryMethod.Factory;
using FactoryMethod.Product;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = TemplateEnum.Books;
            AbstractOrder order;
            IFactory factory;

            switch (template)
            {
                case TemplateEnum.Shopee:

                    factory = new ShopeeFactory();
                    order = factory.CreateOrder();
                    break;

                case TemplateEnum.Books:

                    factory = new BooksFactory();
                    order = factory.CreateOrder();
                    break;

                default:

                    throw new Exception($"template not valid ");
            }

            order.Upload();
        }
    }
}