using System;
using System.ComponentModel.DataAnnotations;

namespace DAVA.Models
{
    public class UpdateActivityModel : CreateActivityModel
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public bool IsFinished { get; set; }
    }
}
