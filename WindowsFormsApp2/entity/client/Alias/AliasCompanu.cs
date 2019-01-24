using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entity
{
    public class AliasCompanu
    {
        public AliasCompanu()
        {

        }

        public AliasCompanu (string companuName, string registrationNumber)
        {
            RegistrationNumber = registrationNumber;
            CompanuName = companuName;
        }
        public string RegistrationNumber { get; set; }
        public string CompanuName { get; set; }
    }
}
