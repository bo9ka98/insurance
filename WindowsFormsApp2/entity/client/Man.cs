using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Man
    {
        public Man()
        {
            ManAlias = new AliasMan();
        }


        public Man(AliasMan aliasMan, DateTime dateOfBirth, DateTime experienceDrivingCar,
            string sex, string address, string phone)
        {
            ManAlias = aliasMan;
            DateOfBirth = dateOfBirth;
            ExperienceDrivingCar = experienceDrivingCar;
            Sex = sex;
            AddressResidence = address;
            PhoneNumber = phone;
        }
        public AliasMan ManAlias  { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public DateTime ExperienceDrivingCar { get; set; }
        public string AddressResidence { get; set; }
        public string PhoneNumber { get; set; }
        public string photoMan; //заглушка
    }
}
