using System;
using SimpleFactory.Enum;
using SimpleFactory.Product;

namespace SimpleFactory
{
    public class Factory
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
    }
}