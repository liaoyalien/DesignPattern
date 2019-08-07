using System;

namespace AbstractFactory.Product
{
    public class BooksOrder : AbstractOrder
    {
        public override void Upload()
        {
            Console.WriteLine("Books Order Uploaded");
        }
    }
}