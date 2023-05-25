﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByEmailAsync(string email);
    }
}
