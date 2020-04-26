using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndoriZaika.Core
{
    public class Recipe
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonIgnore]
        [JsonProperty("cuisine")]
        public Cuisine Cuisine { get; set; }
        
        [JsonProperty("recipeType")]
        [JsonIgnore]
        public RecipeType RecipeType { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("videoPath")]
        public string VideoPath { get; set; }

        [JsonProperty("thumbnailImagePath")]
        public string ThumbnailImagePath { get; set; }
    }

    
}
