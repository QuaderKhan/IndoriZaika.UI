using IndoriZaika.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndoriZaika.Data
{
    public interface ICuisineData
    {
        IEnumerable<Cuisine> GetAllCuisines();
    }

    
}
