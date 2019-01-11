using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NuturalClientDao : EntitySerializableDao<NuturalClient>
    {
        public NuturalClientDao(BinaryFormatter binaryFormatter) : base(binaryFormatter) { }

    }
}
