using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModels_23._03.Base;

namespace DataModels_23._03.Models
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
