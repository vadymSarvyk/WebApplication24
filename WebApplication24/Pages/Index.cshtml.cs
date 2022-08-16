using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Implementations;
using WebApplication24.Interfaces;
using WebApplication24.Models;

namespace WebApplication24.Pages
{
    public class IndexModel : PageModel
    {
        public Product product { get; set; }
        public ICalc calculator { get; set; }
        public IndexModel(ICalc calculator)
        {
            this.calculator = calculator;
            product = new Product { Id = 1, Title = "Product1", Price = 34.23 };
        }

        public void OnGet()
        {
            product = calculator.CalculateFinalPrice(product);
        }
    }
}
