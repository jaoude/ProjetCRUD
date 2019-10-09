﻿using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken ct);
        Task<Person> GetPersonAsync(Guid id, CancellationToken ct);
        void CreatePerson(Person personEntity);

    }
}