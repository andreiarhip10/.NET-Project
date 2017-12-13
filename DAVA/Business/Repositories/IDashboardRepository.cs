using System;
using System.Collections.Generic;
using Data.Entities;

namespace Business.Repositories
{
    public interface IDashboardRepository
    {
        IReadOnlyList<Dashboard> GetAll();
        Dashboard GetById(Guid id);
        void Add(Dashboard dashboard);
        void Edit(Dashboard dashboard);
        void Delete(Guid id);
    }
}
