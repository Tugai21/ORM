using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class Role : BaseModel
    {
        public string RoleName { get; set; }
        public ICollection<Crew> Crews { get; set; } = new List<Crew>();
    }
}
