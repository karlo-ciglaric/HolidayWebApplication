using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolidayWebApplication.Models;

namespace HolidayWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHolidayRepository holidayRepository;

        public HomeController(IHolidayRepository _holidayRepository)
        {
            holidayRepository = _holidayRepository;
        }

        public IActionResult Add(Holiday holiday)
        {
            holidayRepository.AddHoliday(holiday);



            return View("Index", holiday);
        }

        public IActionResult Update(Holiday holiday)
        {
            holidayRepository.UpdateHoliday(holiday);

            return View("Index", holiday);

        }
        public IActionResult Next(Holiday holiday)
        {
            var nextHoliday = holidayRepository.GetHolidayById(holiday.Id + 1);


            return RedirectToAction("Index", nextHoliday);

        }

        public IActionResult Previous(Holiday holiday)
        {
            var prevHoliday = holidayRepository.GetHolidayById(holiday.Id - 1);

            return RedirectToAction("Index", prevHoliday);

        }

        public IActionResult Index(Holiday holiday)
        {
            Holiday _holiday;


            if (holiday.Id != 0)
            {
                _holiday = holidayRepository.GetHolidayById(holiday.Id);
                return View(_holiday);
            }
            else
            {
                _holiday = holidayRepository.GetHolidayById(1);
                return View(_holiday);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
