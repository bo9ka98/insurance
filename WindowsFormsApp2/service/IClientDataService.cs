using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IClientDataService <T>
    {
        //private List<T> listObject;
        List<IndividClient> ReadListIndividClientDao(IndividClient individClient);
        void AddListIndividClientDao(IndividClient individClient);
    }
}
