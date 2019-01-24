using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entity
{
    public class InsuranceCases
    {
        public string Name { get; set; }
        public int PercentPayout { get; set; }

        public InsuranceCases(string name, int percentPayout)
        {
            Name = name;
            PercentPayout = percentPayout;
        }
    }
}
