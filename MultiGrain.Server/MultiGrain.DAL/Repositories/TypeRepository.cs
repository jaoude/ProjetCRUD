﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
namespace MultiGrain.DAL.Repositories
{
    public class TypesRepository : Repository<Types>, ITypesRepository
    {
        public TypesRepository(MultiGrainDbContext _db): base(_db)
        {

        }
    }
}
