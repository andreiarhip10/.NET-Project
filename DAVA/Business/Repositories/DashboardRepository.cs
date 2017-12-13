using System;
using System.Collections.Generic;
using System.Linq;
using Data.Context;
using Data.Entities;

namespace Business.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly IDatabaseService _databaseService;

        public DashboardRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public IReadOnlyList<Dashboard> GetAll()
        {
            return _databaseService.Dashboards.ToList();
        }

        public Dashboard GetById(Guid id)
        {
            return _databaseService.Dashboards.FirstOrDefault(t => t.Id == id);
        }

        public void Add(Dashboard dashboard)
        {
            _databaseService.Dashboards.Add(dashboard);
            _databaseService.SaveChanges();
        }

        public void Edit(Dashboard dashboard)
        {
            _databaseService.Dashboards.Update(dashboard);
            _databaseService.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var dashboard = GetById(id);
            _databaseService.Dashboards.Remove(dashboard);
            _databaseService.SaveChanges();
        }

    }
}
