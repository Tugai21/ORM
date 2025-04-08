using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.BaseModels;

namespace Cars.Models
{
    public class Model : BaseModel
    {   
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Consumption { get; set; }
        public int Year { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
        public List<Engine> Engines { get; set; }
        public List<ModelEngine> ModelEngines { get; set; }
    }
}
