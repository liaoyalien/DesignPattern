using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Enum;
using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class SimpleFactory
    {
        public static AbstractOrder CreateOrder(TemplateEnum template)
        {
            switch (template)
            {
                case TemplateEnum.Shopee:
                    return new ShopeeOrder();
                case TemplateEnum.Books:
                    return new BooksOrder();           
                default:
                    throw new Exception($"template not valid ");

            }
        }

        public static AbstractInvoice CreateInvoice(TemplateEnum template)
        {
            switch (template)
            {
                case TemplateEnum.Shopee:
                    return new ShopeeInvoice();
                case TemplateEnum.Books:
                    return new ShopeeInvoice();
                default:
                    throw new Exception($"template not valid ");

            }
        }
    }
}
