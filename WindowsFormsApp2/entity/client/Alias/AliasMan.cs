using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entity
{
    [Serializable]
    public class AliasMan
    {
        public AliasMan()
        {

        }

        public AliasMan(string surname, string name, string middleName)
        {
            Surname = surname;
            Name = name;
            MiddleName = middleName;
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
    }
}
