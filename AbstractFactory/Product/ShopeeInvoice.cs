using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class ShopeeInvoice: AbstractInvoice
    {
        public override void Upload()
        {
            Console.WriteLine("Shopee Invoice Uploaded");
        }
    }
}
