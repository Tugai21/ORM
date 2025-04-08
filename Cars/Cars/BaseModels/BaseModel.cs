using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BaseModels
{
    public class BaseModel : IBaseModels
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
