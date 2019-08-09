using System;
using AbstractFactory.Enum;
using AbstractFactory.Product;
using System.Reflection;

namespace AbstractFactory.Factory
{
    public class SimpleFactoryReflection
    {
        private static readonly string AssemblyName = "AbstractFactory";

        public static AbstractOrder CreateOrder(TemplateEnum template)
        {
            var className = $"{AssemblyName}.Product.{template.ToString()}Order";
            return (AbstractOrder) Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static AbstractInvoice CreateInvoice(TemplateEnum template)
        {
            var className = $"{AssemblyName}.Product.{template.ToString()}Invoice";
            return (AbstractInvoice)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
