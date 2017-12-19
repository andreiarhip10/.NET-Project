using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Activity
    {
        private Activity()
        {
            
        }

        [Key]
        [Required]
        public Guid Id { get; set; } //private setters

        [Required(ErrorMessage = "A Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$",
            ErrorMessage = "Only lowercase and uppercase characters are allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Description is required.")]
        [MaxLength(200, ErrorMessage = "A maximum of 200 characters is allowed.")]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public Guid DashboardId { get; set; }

        [Required(ErrorMessage = "A Starting Time is required.")]
        public DateTime StartingTime { get; set; }

        [Required(ErrorMessage = "An Ending Time is required. ")]
        public DateTime EndingTime { get; set; }

        [Required]
        public bool IsFinished { get; set; }

        [ForeignKey("DashboardId")]
        public Dashboard Dashboard { get; set; }

        public static Activity Create(string name, string description, string type, Guid dashboardId, DateTime startingTime, DateTime endingTime)
        {
            var instance = new Activity { Id = Guid.NewGuid() };
            instance.Update(name, description, type, dashboardId, startingTime, endingTime, false);
            return instance;
        }

        public void Update(string name, string description, string type, Guid dashboardId, DateTime startingTime, DateTime endingTime, bool isFinished)
        {
            this.Name = name;
            this.Description = description;
            this.DashboardId = dashboardId;
            this.Type = type;
            this.StartingTime = startingTime;
            this.EndingTime = endingTime;
            this.IsFinished = isFinished;
        }
    }
}
