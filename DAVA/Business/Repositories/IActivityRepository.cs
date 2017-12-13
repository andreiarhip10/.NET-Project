using System;
using System.Collections.Generic;
using Data.Entities;

namespace Business.Repositories
{
    public interface IActivityRepository
    {
        IReadOnlyList<Activity> GetAll();
        Activity GetById(Guid id);
        void Add(Activity activity);
        void Edit(Activity activity);
        void Delete(Guid activity);
    }
}
