﻿using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository:BaseRepository<User>
    {
        public UserRepository():base()
        {

        }
    }
}
