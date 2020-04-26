using IndoriZaika.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace IndoriZaika.Data
{
    public class RecipeData : IRecipeData
    {
        private IEnumerable<Recipe> recipes;
        public RecipeData()
        {
            recipes = new List<Recipe> {
            new Recipe{ Id=1, Name="Chicken Biryani", Description="Malabar chicken biryani", RecipeType=RecipeType.NonVeg },
            new Recipe{ Id=2, Name="Mutton Biryani", Description="Mutton goat biryani", RecipeType=RecipeType.NonVeg },
            new Recipe{ Id=3, Name="Chicken Korma", Description="Indori style korma", RecipeType=RecipeType.NonVeg },
            new Recipe{ Id=4, Name="Arvi Masala", Description="Arvi gravy spicy", RecipeType=RecipeType.Veg },
            new Recipe{ Id=5, Name="Egg Masala", Description="Indori style Egg Masala", RecipeType=RecipeType.Egg }
        };
        }
        public IEnumerable<Recipe> GetAllRecipes()
        {
            
            return from r in recipes
                   orderby r.Id
                   select r;
                   
        }

        public IEnumerable<Recipe> GetRecipeById(int id)
        {
            return (from r in recipes
                    where string.IsNullOrEmpty(r.Id.ToString()) || r.Id == id
                    select r);
        }
    }
}
