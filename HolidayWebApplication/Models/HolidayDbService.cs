using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayWebApplication.Models
{
    public class HolidayDbService : IHolidayRepository
    {
        private readonly HolidayDbContext context;
        public HolidayDbService(HolidayDbContext _context)
        {
            context = _context;
        }
        public void AddHoliday(Holiday holiday)
        {
            throw new NotImplementedException();
        }

        public void DeleteHoliday(Holiday holiday)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Holiday> GetAllHolidays()
        {
            throw new NotImplementedException();
        }

        public Holiday GetHolidayById(int holidayId)
        {
            throw new NotImplementedException();
        }

        public void UpdateHoliday(Holiday holiday)
        {
            throw new NotImplementedException();
        }
    }
}
