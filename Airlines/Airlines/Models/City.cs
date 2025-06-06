﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airlines.BaseModels;

namespace Airlines.Models
{
    public class City : BaseModel
    {
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public ICollection<Airport> Airports { get; set; } = new List<Airport>();
    }
}
