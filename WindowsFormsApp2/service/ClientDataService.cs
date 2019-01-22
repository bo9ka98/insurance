using System;
using System.IO;
using System.Collections.Generic;
using Model.entity;

namespace Model
{
    public class ClientDataService  : IClientDataService<IndividClient>
    {
        private List<IndividClient> listIndividClientDao;
        IndividClientDao _individClientDao;

        public ClientDataService(IndividClientDao individClientDao)
        {
            _individClientDao = individClientDao;
            List<IndividClient> saveListClient = _individClientDao.DeserializeList();
            listIndividClientDao = saveListClient;
            if (listIndividClientDao == null)
            {
                listIndividClientDao = new List<IndividClient>();
            }
        }

        ~ClientDataService()
        { 
            _individClientDao.SerializeList(listIndividClientDao);
            listIndividClientDao = null;
        }

        public List<IndividClient> ReadListIndividClientDao(IndividClient individClient)
        {
            List<IndividClient> saveListClient = new List<IndividClient>();
            listIndividClientDao.ForEach(iCD => AddToListSimilarPattern(saveListClient, individClient, iCD));
            return saveListClient;
        }

        public void AddListIndividClientDao(IndividClient individClient)
        {
            listIndividClientDao.Add(individClient);
        }

        private void AddToListSimilarPattern
            (List<IndividClient> saveListClient, IndividClient patternClient, IndividClient client)
        {
            if(patternClient.ManAlias == client.ManAlias)
            {
                saveListClient.Add(client);
            }
        }
 
    }
}
