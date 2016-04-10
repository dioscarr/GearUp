using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GearUp.Models
{
    public class Vehicle
    {

        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Model")]
        public string model { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime year { get; set; }
        [Required]
        [ForeignKey("make")]
        public int makeid { get; set; }
        [Required]
        [Display(Name = "Color")]
        public string color { get; set; }      
        [Required]
        public string BIN { get; set; }

        public virtual Make make { get; set; } 

        public Vehicle()
        {
        }
    }
}