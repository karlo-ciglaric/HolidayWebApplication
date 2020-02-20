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

            context.Holidays.OrderBy(h => h.Id);



            context.SaveChanges();
        }

        public void UpdateHoliday(Holiday holiday)
        {
            context.Holidays.Update(holiday);

            context.SaveChanges();
        }

        public void DeleteHoliday(Holiday holiday)
        {
            context.Holidays.Remove(holiday);

            context.SaveChanges();
        }

        public void PrintHolidays()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Holiday> GetAllHolidays()
        {
            int i;
            return context.Holidays;
        }

        public Holiday GetHolidayById(int holidayId)
        {
            return context.Holidays.Where(h => h.Id == holidayId).First();
        }

        public Holiday GetNextHoliday(Holiday holiday)
        {

            return context.Holidays.Where(h => h.Id >= holiday.Id + 1).OrderBy(h => h.Id).FirstOrDefault();
        }

        public Holiday GetPrevHoliday(Holiday holiday)
        {
            Holiday _holiday = null;
            List<Holiday> holidayList = context.Holidays.ToList();

            if (holiday.Id != 1)
            {
               

                _holiday = context.Holidays.Where(h => h.Id < holiday.Id).OrderByDescending(h => h.Id).FirstOrDefault();
                return _holiday;
            }

            return context.Holidays.OrderBy(h => h.Id).Last();
        }

        
    }
}
