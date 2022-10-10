﻿
namespace NeuRecipe.Domain.Entity
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
