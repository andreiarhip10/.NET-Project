using System;
using System.ComponentModel.DataAnnotations;

namespace DAVA.Models
{
    public class CreateActivityModel
    {
        [Required(ErrorMessage = "A Name is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,50}$",
            ErrorMessage = "Only lowercase and uppercase characters are allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Description is required.")]
        [MaxLength(200, ErrorMessage = "A maximum of 200 characters is allowed.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A Type is required.")]
        [RegularExpression(@"(housework|study/work|leisure)",
            ErrorMessage = "Type can only be housework, study/work or leisure.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "A DashboardId is required.")]
        public Guid DashboardId { get; set; }

        [Required(ErrorMessage = "A Starting Time is required.")]
        public DateTime StartingTime { get; set; }

        [Required(ErrorMessage = "An Ending Time is required. ")]
        public DateTime EndingTime { get; set; }
    }
}
