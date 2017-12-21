using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Data.Entities;

namespace DAVA.Models
{
    public class CreateDashboardModel
    {
        [Required(ErrorMessage = "A Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "A Type is required.")]
        [RegularExpression(@"(housework|study/work|leisure)",
            ErrorMessage = "Type can only be housework, study/work or leisure.")]
        public string Type { get; set; }

        //public List<Activity> Activities { get; set; }
    }
}
