using System;
using System.Collections.Generic;
using Model.entity;

namespace Model
{
    public interface IClientDataService <T>
    {
        //private List<T> listObject;
        List<IndividClient> ReadListIndividClientDao(IndividClient individClient);
        void AddListIndividClientDao(IndividClient individClient);
    }
}
