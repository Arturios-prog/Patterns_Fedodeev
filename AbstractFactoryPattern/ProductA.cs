using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ProductA1 : IProduct
    {
        public string GetName()
        {
            return "Product A1";
        }
    }

    public class ProductA2 : IProduct
    {
        public string GetName()
        {
            return "Product A2";
        }
    }

    public class ProductB1 : IProduct
    {
        public string GetName()
        {
            return "Product B1";
        }
    }

    public class ProductB2 : IProduct
    {
        public string GetName()
        {
            return "Product B2";
        }
    }
}
