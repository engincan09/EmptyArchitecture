﻿using Core.Persistence.Repositories;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories.Users
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
    {
    }
}
