using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.BaseModels;

namespace Cars.Models
{
    public class Car : BaseModel
    {
        public ICollection<Model> Models { get; set; } = new List<Model>();
    }
}
