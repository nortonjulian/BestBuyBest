using System;
using System.Collections.Generic;

namespace BestBuyBestPracticesConsoleUI
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }

    public void CreateProduct(string name, double price, int categoryID)
    {

    }
}
