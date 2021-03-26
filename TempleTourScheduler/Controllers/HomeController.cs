using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TempleTourScheduler.Models;
using TempleTourScheduler.Models.ViewModels;

namespace TempleTourScheduler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private TempleTourDbContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, TempleTourDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Display AvailableTimes View, separating them by Day of Week
        [HttpGet]
        public IActionResult AvailableTimes()
        {
            return View(new AvailableTimesViewModel
            {
                Monday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Monday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
                Tuesday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Tuesday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
                Wednesday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Wednesday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
                Thursday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Thursday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
                Friday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Friday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
                Saturday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Saturday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
                Sunday = _context.TimeBlocks
                    .Where(x => x.DayOfWeek == "Sunday" && x.IsBooked == false).OrderBy(x => x.HourBlock),
            });
        }

        // Pass the parameters into the new appointment
        [HttpPost]
        public IActionResult AvailableTimes(int timeId, string dayOfWeek, string hourBlock)
        {
            var timeslot = hourBlock;
            var dayofweek = dayOfWeek;
            var ttimeId = timeId;

            return View("SignUpForm", new Appointment
            {
                TimeSlot = timeslot,
                DayOfWeek = dayofweek,
                TimeId = ttimeId
            });
        }

        [HttpGet]
        public IActionResult SignUpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpForm(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                var original = _context.TimeBlocks.Find(appointment.TimeId);

                // Change book status of the time scheduled when submitted
                if (original != null)
                {
                    original.IsBooked = true;
                    _context.SaveChanges();
                }

                // Add the appointment to the database
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
                TempData["message"] = "Successfully Booked.";
                return Redirect("/Home");
            }

            return View(appointment);
        }

        // Display the appointments by Day of Week
        public IActionResult AppointmentList()
        {
            return View(new AppointmentListViewModel
            {
                Monday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Monday"),
                Tuesday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Tuesday"),
                Wednesday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Wednesday"),
                Thursday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Thursday"),
                Friday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Friday"),
                Saturday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Saturday"),
                Sunday = _context.Appointments
                    .Where(x => x.DayOfWeek == "Sunday"),
            });
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
