using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.BaseModels;

namespace Cars.Models
{
    public class ModelEngine : BaseModel
    {
        public int ModelId { get; set; }
        public int EngineId { get; set; }
    }
}
