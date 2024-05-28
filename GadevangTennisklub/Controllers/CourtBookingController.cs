using Microsoft.AspNetCore.Mvc;
using GadevangTennisklub.Data;
using GadevangTennisklub.Models;

namespace GadevangTennisklub.Controllers
{
    public class CourtBookingController : Controller
    {
        private readonly ApplicationDbContext _context1;

        public CourtBookingController(ApplicationDbContext context)
        {
            _context1 = context;
        }

        public async Task<IActionResult> Index()
        {
            var bookings = _context1.CourtBookings.Include(b =>
            {
                return b.Member;
            });
            return View(await bookings.ToListAsync());
        }

        private IActionResult View(object value)
        {
            throw new NotImplementedException();
        }

        public IActionResult Create()
        {
            ViewData["Members"] = _context1.Members.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourtBooking booking)
        {
            if (ModelState.IsValid)
            {
                object value1 = _context1.Add(booking);
                await _context1.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Members"] = _context1.Members.ToList();
            return View(booking);
        }
    }
}
