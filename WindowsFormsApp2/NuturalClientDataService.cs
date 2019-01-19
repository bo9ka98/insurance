using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class NuturalClientDataService : IClientDataService<IndividClient>
    {
        public List<IndividClient> ListObject { get; set; } 
    }
}
