using Microsoft.AspNetCore.Mvc;
using GadevangTennisklub.Data;
using GadevangTennisklub.Models;
namespace GadevangTennisklub.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly object context;

        public MemberController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Members.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        public ApplicationDbContext Get_context()
        {
            return _context;
        }

        public object GetContext()
        {
            return context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member member, ApplicationDbContext _context, object context)
        {
            if (ModelState.IsValid)
            {
                object value = -context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }
    }
}
