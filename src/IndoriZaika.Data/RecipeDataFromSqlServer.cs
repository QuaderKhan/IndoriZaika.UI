using IndoriZaika.Core;
using IndoriZaika.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IndoriZaika.Data
{
    public class RecipeDataFromSqlServer : IRecipeData
    {
        public IEnumerable<Recipe> GetAllRecipes()
        {
            string response = ServiceInvoker.GetServiceResults("http://localhost:8000/api/Recipes");

            return GenerateRecipesList(response);
        }

        public IEnumerable<Recipe> GetRecipeById(int Id)
        {
            if (Id.Equals(0))
            {
                return GetAllRecipes();
            }
            else
            {
                string response = ServiceInvoker.GetServiceResults("http://localhost:8000/api/Recipes/" + Id);

                return GenerateRecipesList(response);
            }
        }

        private IList<Recipe> GenerateRecipesList(string jsonString)
        {
            var result = JsonConvert.DeserializeObject<IList<Recipe>>(jsonString);
            return result;
        }
    }
}
