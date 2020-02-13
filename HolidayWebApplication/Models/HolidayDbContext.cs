using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayWebApplication.Models
{
    public class HolidayDbContext : DbContext
    {
        public HolidayDbContext(DbContextOptions<HolidayDbContext> options) : base(options)
        {

        }

        // DbSet is the table in the database
        public DbSet<Holiday> Holidays { get; set; }
    }
}
