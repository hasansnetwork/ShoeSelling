using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeSelling.Models
{
    public class Shoe
    {
        [Required]
        [Key]
        public int ShoeID { get; set; }
        [Required]
        public string PhotoID { get; set; }
        [Required]
        public string SizeID { get; set; }
        [Required]
        public string ColorID { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string OrderID { get; set; }
        [Required]
        public string SeasonID { get; set; }

    }
}
