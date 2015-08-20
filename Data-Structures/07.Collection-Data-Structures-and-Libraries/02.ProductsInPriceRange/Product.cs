using System;
using System.Collections.Generic;

namespace ProductsInPriceRange
{
    public class Product : IComparable<Product>
    {
        public Product()
            : this(0, null)
        {          
        }

        public Product(int price, string name)
        {
            this.Price = price;
            this.Name = name;
        }

        public int Price { get; set; }

        public string Name { get; set; }

        #region IComparable implementation

        public int CompareTo(Product product)
        {
            return this.Price - product.Price;
        }

        #endregion
    }
}

