using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var std1 = "test";


            ChangeReferenceType(std1);

            Console.WriteLine(std1);
        }

        static void ChangeReferenceType(string std2)
        {
            std2 = "Steve";
        }
    }
}
