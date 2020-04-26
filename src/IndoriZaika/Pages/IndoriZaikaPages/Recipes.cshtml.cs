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
    public class RecipesModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IRecipeData recipeData;

        public IEnumerable<Recipe> recipes { get; set; }
        public Recipe recipe { get; set; }
        public string PageHeading { get; set; }
        public RecipesModel(IConfiguration configuration, IRecipeData recipeData)
        {
            this.configuration = configuration;
            this.recipeData = recipeData;
        }
        public void OnGet(int searchId)
        {

            PageHeading = configuration["RecipesPageHeading"];
            if (searchId.Equals(0))
            {
                recipes = recipeData.GetAllRecipes();
            }
            else
                recipes = recipeData.GetRecipeById(searchId);
        }

    }
}
