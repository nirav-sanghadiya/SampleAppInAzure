﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
     public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisinType Cuisine { get; set; }
    }
}
