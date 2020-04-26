using IndoriZaika.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IndoriZaika.Data
{
    public interface IRecipeData
    {
        IEnumerable<Recipe> GetAllRecipes();

        IEnumerable<Recipe> GetRecipeById(int Id);
    }
}
