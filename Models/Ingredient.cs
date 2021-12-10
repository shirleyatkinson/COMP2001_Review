using System;
using System.Collections.Generic;

#nullable disable

namespace COMP2001_Review.Models
{
    public partial class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public bool? Allergen { get; set; }
    }
}
