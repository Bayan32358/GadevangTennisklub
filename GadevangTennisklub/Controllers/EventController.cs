using Microsoft.AspNetCore.Mvc;
using GadevangTennisklub.Data;
using GadevangTennisklub.Models;
namespace GadevangTennisklub.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Events.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public ApplicationDbContext Get_context()
        {
            return _context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event evt, ApplicationDbContext _context)
        {
            if (ModelState.IsValid)
            {
                object value = _context.Add(evt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(evt);
        }
    }
}
