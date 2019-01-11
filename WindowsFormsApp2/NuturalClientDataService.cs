using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class NuturalClientDataService : IClientDataService<NuturalClient>
    {
        public List<NuturalClient> ListObject { get; set; } 
    }
}
