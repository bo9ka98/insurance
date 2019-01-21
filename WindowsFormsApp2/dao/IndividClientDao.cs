

using System.Runtime.Serialization.Formatters.Binary;


namespace Model
{
    public class IndividClientDao : СommonEntitySerializableDao<IndividClient>
    {
        public IndividClientDao(BinaryFormatter binaryFormatter) : base(binaryFormatter) { }

    }
}
