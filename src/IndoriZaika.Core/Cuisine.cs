using System;
using System.Collections.Generic;
using System.Text;

namespace IndoriZaika.Core
{
    public partial class Cuisine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Type  { get; set; }

    }
}
