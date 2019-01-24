

using System.Runtime.Serialization.Formatters.Binary;
using Model.entity;

namespace Model.dao
{
    public class IndividClientDao : СommonEntitySerializableDao<IndividClient>
    {
        public IndividClientDao(BinaryFormatter binaryFormatter) : base(binaryFormatter) { }

    }
}
