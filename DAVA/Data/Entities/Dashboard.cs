using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Data.Entities.Validation;

namespace Data.Entities
{
    public class Dashboard : Validations
    {
        private Dashboard()
        {
            
        }

        [Key]
        public Guid Id { get; private set; }

        public DateTime Date { get; private set; }

        public string Type { get; private set; }

        public virtual List<Activity> Activities { get; set; }

        public static Dashboard Create(DateTime date, string type)
        {
            if(!ValidateDashboard(date, type)) return null;
            var instance = new Dashboard {Id = Guid.NewGuid(), Activities = new List<Activity>()};
            instance.Update(date, type);
            return instance;
        }

        public void Update(DateTime date, string type)
        {
            //ValidateDashboard(date, type);
            Date = date;
            Type = type;
        }

        //public Dashboard GetDashboardById(Guid id)
        //{
        //    return this;
        //}
    }
}
