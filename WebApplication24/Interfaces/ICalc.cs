using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;

namespace WebApplication24.Interfaces
{
  public  interface ICalc
    {
        Product CalculateFinalPrice(Product product);

    }
}
