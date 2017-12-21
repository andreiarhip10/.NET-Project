using System;
using System.ComponentModel.DataAnnotations;

namespace DAVA.Models
{
    public class UpdateDashboardModel : CreateDashboardModel
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
