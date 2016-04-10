using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GearUp.Models
{
    public class Make
    {
        [Required]
        [Key]
        public int id { get; set; }            
        [Required]
        [Display(Name ="Brand Name")]
        public string BrandName { get; set; }
        [Required]
        public string Logo { get; set; }
        
        [Display(Name = "Models")]
        [ForeignKey("vehicles")]
        public string models { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Modified { get; set; }
        [Required]
        public bool isDeleted { get; set; }

       public virtual ICollection<Vehicle> vehicles { get; set; }

        public Make() {
        }
    }
}