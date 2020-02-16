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
            if (holiday == null)
                throw new ArgumentNullException();

            context.Holidays.Add(holiday);

            context.SaveChanges();
        }

        public void DeleteHoliday(Holiday holiday)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Holiday> GetAllHolidays()
        {
            return context.Holidays;
        }

        public Holiday GetHolidayById(int holidayId)
        {
            return context.Holidays.Find(holidayId);
        }

        public void UpdateHoliday(Holiday holiday)
        {
            context.Holidays.Update(holiday);

            context.SaveChanges();
        }
    }
}
