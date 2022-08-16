using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Interfaces;

namespace WebApplication24.Pages
{
    public class PrivacyModel : PageModel
    {
        public ICalc calculator { get; set; }

        public PrivacyModel(ICalc calculator)
        {
            this.calculator = calculator;
        }

        public void OnGet()
        {
        }
    }
}
