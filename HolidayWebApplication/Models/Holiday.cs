using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayWebApplication.Models
{
    public class Holiday
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Destination { get; set; }

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Cost { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public int NoOfDays { get; set; }

        [Required]
        public bool Available { get; set; }
    }
}
