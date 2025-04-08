using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels_23._03.Base;

namespace DataModels_23._03.Models
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; } = null!;
        // public IList<Product> Products { get; set; } = new List<Product>(); // This is a many-to-many relationship.
        public IList<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>(); // This is a many-to-many relationship.
    }
}
