

using System.Runtime.Serialization.Formatters.Binary;


namespace Model
{
    class LegalClientDao : СommonEntitySerializableDao<LegalСlient>
    {
        public LegalClientDao(BinaryFormatter binaryFormatter) : base(binaryFormatter) { }

    }

}
