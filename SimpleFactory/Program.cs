using SimpleFactory.Enum;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = TemplateEnum.Books;
            var pi = Factory.CreateOrder(template);
            pi.Upload();
        }
    }
}