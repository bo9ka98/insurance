

using System.Runtime.Serialization.Formatters.Binary;
using Model.entity;

namespace Model
{
    public class IndividClientDao : СommonEntitySerializableDao<IndividClient>
    {
        public IndividClientDao(BinaryFormatter binaryFormatter) : base(binaryFormatter) { }

    }
}
