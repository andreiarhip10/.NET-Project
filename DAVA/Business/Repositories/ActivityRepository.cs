using System;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Data.Entities;

namespace Business.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly IDatabaseService _databaseService;

        public ActivityRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public IReadOnlyList<Activity> GetAll()
        {
            return _databaseService.Activities.ToList();
        }

        public Activity GetById(Guid id)
        {
            return _databaseService.Activities.FirstOrDefault(t => t.Id == id);
        }

        public void Add(Activity activity)
        {
            _databaseService.Activities.Add(activity);
            _databaseService.SaveChanges();
        }

        public void Edit(Activity activity)
        {
            _databaseService.Activities.Update(activity);
            _databaseService.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var activity = GetById(id);
            _databaseService.Activities.Remove(activity);
            _databaseService.SaveChanges();
        }

    }
}
