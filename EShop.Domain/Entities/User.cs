﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string EmailLogin { get; set; }
    public string Password { get; set; }

}
