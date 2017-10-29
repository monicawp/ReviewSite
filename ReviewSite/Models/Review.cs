using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        [Display(Name = "Vacation Date")]
        public DateTime VacationDate { get; set; }

        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}