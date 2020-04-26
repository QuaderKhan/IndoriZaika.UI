using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndoriZaika.Core;
using IndoriZaika.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace IndoriZaika.Pages
{
    public class CuisinesModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly ICuisineData cuisineData;

        public string Message { get; set; }
        public IEnumerable<Cuisine> Cuisines { get; set; }
        public CuisinesModel(IConfiguration config, ICuisineData cuisineData)
        {
            this.config = config;
            this.cuisineData = cuisineData;
        }

        public void OnGet()
        {
            Message = config["CuisinesPageHeading"];
            Cuisines = cuisineData.GetAllCuisines();
        }
    }
}
