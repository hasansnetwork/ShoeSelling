using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSelling.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [Required]
        public string ColorName { get; set; }
    }
}
