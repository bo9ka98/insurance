﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entity
{
    public class PoliceCategori
    {
        public string Name { get; set; }
        public string MaxPrice { get; set; }

        public PoliceCategori(string name, string maxPrice)
        {
            Name = name;
            MaxPrice = maxPrice;
        }
    }
}
