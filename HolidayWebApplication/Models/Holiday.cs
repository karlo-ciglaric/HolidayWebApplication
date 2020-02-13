using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayWebApplication.Models
{
    public class Holiday
    {
        public int Id { get; set; }
        public string Destination { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Cost { get; set; }
        public DateTime DepartureDate { get; set; }
        public int NoOfDays { get; set; }
        public bool Available { get; set; }
    }
}
