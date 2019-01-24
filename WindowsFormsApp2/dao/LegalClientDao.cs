
using System;
using Model.entity;
using System.Runtime.Serialization.Formatters.Binary;


namespace Model.dao
{
    class LegalClientDao : СommonEntitySerializableDao<LegalСlient>
    {
        public LegalClientDao(BinaryFormatter binaryFormatter) : base(binaryFormatter) { }

    }

}
