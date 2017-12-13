using System;
using System.Collections.Generic;
using Business.Repositories;
using Data.Entities;
using DAVA.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAVA.Controllers
{
    [Route("api/[controller]")]
    public class DashboardsController : Controller
    {
        private readonly IDashboardRepository _repository;

        public DashboardsController(IDashboardRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Dashboard> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Dashboard Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreateDashboardModel dashboard)
        {
            var entity = Dashboard.Create(dashboard.Date, dashboard.Type);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] UpdateDashboardModel dashboard)
        {
            var entity = _repository.GetById(id);
            entity.Update(dashboard.Date, dashboard.Type);
            _repository.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
