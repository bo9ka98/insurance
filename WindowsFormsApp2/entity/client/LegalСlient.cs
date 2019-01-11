using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LegalСlient : Companu, IClient
    {
        public LegalСlient()
        {

        }

        public LegalСlient(AliasCompanu companuAlias, AliasMan managerAlias, AliasMan accountantAlias,
           string addressResidence, string phoneNumber)
        {
            CompanuAlias = companuAlias;
            DirectorAlias = managerAlias;
            AccountantAlias = accountantAlias;
            AddressResidence = addressResidence;
            PhoneNumber = phoneNumber;
        }
        void IClient.SetContract()
        {
            throw new NotImplementedException();
        }
    }
}
