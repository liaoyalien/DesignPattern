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

            IFactory factory;

            switch (template)
            {
                case TemplateEnum.Shopee:
                    factory = new ShopeeFactory();                  
                    break;

                case TemplateEnum.Books:
                    factory = new BooksFactory();
                    break;

                default:

                    throw new Exception($"template not valid ");
            }
            var order = factory.CreateOrder();
            order.Upload();
        }
    }
}