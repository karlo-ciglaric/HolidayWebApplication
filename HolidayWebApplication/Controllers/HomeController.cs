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

            return View();
        }

        public IActionResult Index(Holiday _holiday)
        {
            Holiday holiday;

            if (_holiday == null)
            {
                
            }

            holiday = _holiday;

            return View(holiday);
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
