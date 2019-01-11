using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class NuturalClient : Man, IClient
    {
        public NuturalClient(AliasMan aliasMan, DateTime dateOfBirth, DateTime experienceDrivingCar,
           string sex, string address, string phone)
        {
            ManAlias = aliasMan;
            DateOfBirth = dateOfBirth;
            ExperienceDrivingCar = experienceDrivingCar;
            Sex = sex;
            AddressResidence = address;
            PhoneNumber = phone;
        }

        void IClient.SetContract()
        {
            throw new NotImplementedException();
        }
    }
}
