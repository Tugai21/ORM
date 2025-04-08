using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.BaseModels;

namespace Cars.Models
{
    public class Engine : BaseModel
    {
        public double HorsePower { get; set; }
        public double Torque { get; set; }
        public int CylinderCount { get; set; }
        public List<Model> Models { get; set; }
        public List<ModelEngine> ModelEngines { get; set; }
        public int? FuelId { get; set; }
        public Fuel? Fuel { get; set; } 
    }
}
