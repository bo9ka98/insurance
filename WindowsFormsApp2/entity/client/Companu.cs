using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class Companu
    {
        public Companu()
        {

        }

        public Companu(AliasCompanu companuAlias, AliasMan directorAlias, AliasMan accountantAlias,
           string addressResidence, string phoneNumber)
        {
            CompanuAlias = companuAlias;
            DirectorAlias = directorAlias;
            AccountantAlias = accountantAlias;
            AddressResidence = addressResidence;
            PhoneNumber = phoneNumber;
        }
        public AliasCompanu CompanuAlias { get; set; }
        public AliasMan DirectorAlias { get; set; }
        public AliasMan AccountantAlias { get; set; }
        public string AddressResidence { get; set; }
        public string PhoneNumber { get; set; }
    }
}
