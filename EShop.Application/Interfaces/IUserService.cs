﻿using EShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Interfaces;
public interface IUserService:IUserRepository<User>
{
    User Login(string userLogin, string password);
}
