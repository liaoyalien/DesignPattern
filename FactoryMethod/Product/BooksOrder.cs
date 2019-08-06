using System;

namespace FactoryMethod.Product
{
    public class BooksOrder : AbstractOrder
    {
        public override void Upload()
        {
            Console.WriteLine("Books Order Uploaded");
        }
    }
}