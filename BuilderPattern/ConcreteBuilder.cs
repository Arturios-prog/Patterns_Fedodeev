using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("PartX");
        }

        public void BuildPartB()
        {
            _product.Add("PartY");
        }

        public void BuildPartC()
        {
            _product.Add("PartZ");
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
