//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient
    {
        public Ingredient()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int ingredientId { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string weight { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
