using System;

namespace DAVA.Models
{
    public class CreateActivityModel
    {
        //data annotations here
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Guid DashboardId { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
    }
}
