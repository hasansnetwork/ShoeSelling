using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ShoeSelling.Models
{
    public class ShoesSize
    {

        [Key]
        [Display(Name = "Sıze ID")]
        public int SizeId { get; set; }
        [Display(Name = "EuNumber")]
        public int EuNumber { get; set; }
        [Display(Name = "UkNumber")]
        public int UkNumber { get; set; }
        [Display(Name = "UsNumber")]
        public int UsNumber { get; set; }
    }
}
