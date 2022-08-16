using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Interfaces;
using WebApplication24.Models;

namespace WebApplication24.Implementations
{
    public class TaxCalculate : ICalc
    {
        public Product CalculateFinalPrice(Product product)
        {
            product.Price=Math.Round(product.Price*1.2, 2);
            return product;
        }
    }
}
