using System;
using System.Collections.Generic;
using Model.entity;

namespace Model.service
{
    internal interface IClientDataService <T>
    {
        //private List<T> listObject;
        List<IndividClient> ReadListIndividClientDao(IndividClient individClient);
        void AddListIndividClientDao(IndividClient individClient);
    }
}
