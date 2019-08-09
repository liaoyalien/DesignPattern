using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Enum;
using AbstractFactory.Factory;
using AbstractFactory.Product;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Factory
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
            var invoice = factory.CreateInvoice();

            order.Upload();
            invoice.Upload();

            //Simple Factory
            var orderS = SimpleFactory.CreateOrder(template);
            var invoiceS = SimpleFactory.CreateInvoice(template);
            orderS.Upload();
            invoiceS.Upload();

            //Simple Factory with Reflection
            var orderR = SimpleFactoryReflection.CreateOrder(template);
            var invoiceR = SimpleFactoryReflection.CreateInvoice(template);
            orderR.Upload();
            invoiceR.Upload();
        }
    }
}
