using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProduct CreateProductA()
        {
            return new ProductA1();
        }

        public IProduct CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProduct CreateProductA()
        {
            return new ProductA2();
        }

        public IProduct CreateProductB()
        {
            return new ProductB2();
        }
    }
}
