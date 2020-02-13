using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayWebApplication.Models
{
    public interface IHolidayRepository
    {
        IEnumerable<Holiday> GetAllHolidays();
        Holiday GetHolidayById(int holidayId);
        void AddHoliday(Holiday holiday);
        void UpdateHoliday(Holiday holiday);
        void DeleteHoliday(Holiday holiday);
    }
}
