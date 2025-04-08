using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class Crew : BaseModel
    {
        public string Name { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

    }
}
