using System;
using System.Collections.Generic;
using Business.Repositories;
using Data.Entities;
using DAVA.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAVA.Controllers
{
    [Route("api/Dashboards/{dashboardId}/Activities")]
    public class ActivitiesController : Controller
    {
        private readonly IActivityRepository _repository;

        public ActivitiesController(IActivityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Activity> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Activity Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreateActivityModel activity)
        {
            var entity = Activity.Create(activity.Name, activity.Description, activity.Type, activity.DashboardId,
                activity.StartingTime, activity.EndingTime);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] UpdateActivityModel activity)
        {
            var entity = _repository.GetById(id);
            entity.Update(activity.Name, activity.Description, activity.Type, activity.DashboardId, activity.StartingTime, activity.EndingTime, activity.IsFinished);
            _repository.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
