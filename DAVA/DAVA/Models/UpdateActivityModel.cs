using System;

namespace DAVA.Models
{
    public class UpdateActivityModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Guid DashboardId { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public bool IsFinished { get; set; }
    }
}
