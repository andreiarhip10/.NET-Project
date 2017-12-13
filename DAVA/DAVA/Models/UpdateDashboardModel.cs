using System;

namespace DAVA.Models
{
    public class UpdateDashboardModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}
