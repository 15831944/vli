﻿using System;
using System.Collections.Generic;
using System.Text;
using Vli.Entity.PO;

namespace Vli.Repository
{
   public interface ISystemUserRepository
    {
        List<SystemUser> ListSystemUser();
    }
}
