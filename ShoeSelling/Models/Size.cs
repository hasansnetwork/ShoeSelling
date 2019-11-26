using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSelling.Models
{
    public class Size
    {

        [Key]
        [Display(Name = "Sıze ID")]
        public int SizeId { get; set; }
        [Display(Name = "Number")]
        public int Number { get; set; }


    }
}
