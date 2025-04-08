using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels_23._03.Base;

namespace DataModels_23._03.Models
{
    [Table("Products", Schema = "Store")]
    public class Product:BaseEntity
    {
        [MaxLength(100)]

        public string ProductName { get; set; } = null!;
        [DataType(DataType.Currency, ErrorMessage = "Not a valid price")] // This is a data annotation.
        public decimal Price { get; set; }
        // public IList<Category> Categories { get; set; } = new List<Category>(); // This is a many-to-many relationship.

        public IList<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>(); // This is a many-to-many relationship.

    }
}
