﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Man
    {
        public Alias ManName  { get; set; }
        private DateTime DataOfBirth { get; set; }
        private string Sex { get; set; }
        private string photoMan; //заглушка
        private DateTime ExperienceDrivingCar { get; set; }
        private string AddressResidence { get; set; }
        private string PhoneNumber { get; set; }
    }
}