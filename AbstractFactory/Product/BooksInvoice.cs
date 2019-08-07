using System;

namespace AbstractFactory.Product
{
    public class BooksInvoice: AbstractInvoice
    {
        public override void Upload()
        {
            Console.WriteLine("Books Invoice Uploaded");
        }
    }
}
