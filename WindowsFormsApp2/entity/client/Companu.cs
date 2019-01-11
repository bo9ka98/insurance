using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Companu
    {
        public AliasCompanu CompanuAlias { get; set; }
        public AliasMan ManagerAlias { get; set; }
        public AliasMan AccountantAlias { get; set; }
        public string AddressResidence { get; set; }
        public string PhoneNumber { get; set; }
    }
}
