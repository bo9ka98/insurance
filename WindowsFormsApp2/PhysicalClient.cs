﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class PhysicalClient : Man, IClient
    {
        void IClient.SetContract()
        {
            throw new NotImplementedException();
        }
    }
}
