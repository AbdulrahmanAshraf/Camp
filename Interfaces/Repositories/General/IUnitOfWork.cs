﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Interfaces.Repositories.General
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}
