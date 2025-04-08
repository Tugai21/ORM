using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels_23._03.Base;

namespace DataModels_23._03.Models
{
    public class CategoryProduct:BaseEntity
    {
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } = null!;
        public int? ProductId { get; set; }
        public Product? Product { get; set; } = null!;
    }
}
