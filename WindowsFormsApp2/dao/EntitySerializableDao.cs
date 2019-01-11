

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using Ninject;

namespace Model
{
    public abstract class EntitySerializableDao <T>
    {
        protected string _fileName = typeof(T).Name;
        protected BinaryFormatter _binaryFormatter;

        public EntitySerializableDao(BinaryFormatter binaryFormatter)
        {
            _binaryFormatter = binaryFormatter;
        }

        public void SerializeList(List<T> list)
        {
            
            using (FileStream fileStream = new FileStream(string.Format(_fileName + "e.dat"), FileMode.OpenOrCreate))
            {
                _binaryFormatter.Serialize(fileStream, list);
                Console.WriteLine("SerializeblList" + string.Format(_fileName + "e.dat"));
                Console.WriteLine(list);
            }
        }

        public List<T> DeserializeList()
        {
            List<T> list = null;
            using (FileStream fileStream = new FileStream(string.Format(_fileName + "e.dat"), FileMode.OpenOrCreate))
            {
                list = (List<T>)_binaryFormatter.Deserialize(fileStream);
                Console.WriteLine("DeserializeList");
                Console.WriteLine(list);
            }
            return list;
        }


    }
}
