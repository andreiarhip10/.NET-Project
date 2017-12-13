using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Dashboard
    {
        private Dashboard()
        {
            
        }

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "A Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "A Type is required.")]
        public string Type { get; set; }

        public List<Activity> Activities { get; set; }

        public static Dashboard Create(DateTime date, string type)
        {
            var instance = new Dashboard {Id = Guid.NewGuid(), Activities = new List<Activity>()};
            instance.Update(date, type);
            return instance;
        }

        public void Update(DateTime date, string type)
        {
            this.Date = date;
            this.Type = type;
        }
    }
}
