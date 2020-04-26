using IndoriZaika.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IndoriZaika.Data
{
    public class InMemoryCuisineData : ICuisineData
    {
        private List<Cuisine> cuisines;

        public InMemoryCuisineData()
        {
            cuisines = new List<Cuisine> {
             new Cuisine{  Name="Mughalai", Type=Cuisine.CuisineType.NonVeg},
             new Cuisine{  Name="Chinese", Type=Cuisine.CuisineType.NonVeg},
             new Cuisine{  Name="Indori", Type=Cuisine.CuisineType.Veg}
            };
        }

        public IEnumerable<Cuisine> GetAllCuisines()
        {
            return from c in cuisines
                   orderby c.Name
                   select c;
        }
    }
}
