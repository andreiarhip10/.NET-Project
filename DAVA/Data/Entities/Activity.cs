using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Entities.Validation;

namespace Data.Entities
{
    public class Activity : Validations
    {
        private Activity()
        {
            
        }

        [Key]
        public Guid Id { get; private set; } 

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Type { get; private set; }

        public Guid DashboardId { get; private set; }

        public DateTime StartingTime { get; private set; }

        public DateTime EndingTime { get; private set; }

        public bool IsFinished { get; private set; }

        [ForeignKey("DashboardId")]
        public virtual Dashboard Dashboard { get; set; }

        public static Activity Create(string name, string description, string type, Guid dashboardId, DateTime startingTime, DateTime endingTime)
        {
            if (!ValidateActivity(name, description, type, startingTime, endingTime)) return null;
            var instance = new Activity { Id = Guid.NewGuid() };
            instance.Update(name, description, type, dashboardId, startingTime, endingTime, false);
            //Dashboard.Activities.Add(instance);
            // add to Activities for each dashboard
            return instance;
        }

        public void Update(string name, string description, string type, Guid dashboardId, DateTime startingTime, DateTime endingTime, bool isFinished)
        {
            //Validations.ValidateActivity(name, description, type, startingTime, endingTime);
            Name = name;
            Description = description;
            DashboardId = dashboardId;
            Type = type;
            StartingTime = startingTime;
            EndingTime = endingTime;
            IsFinished = isFinished;
        }

        //public static void AddActivity(Activity activity)
        //{
        //    Dashboard = Dashboard.GetDashboardById(DashboardId);
        //    Dashboard.Activities.Add(activity);
        //}
    }
}
