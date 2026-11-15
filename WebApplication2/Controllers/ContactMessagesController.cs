using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    public class ContactMessagesController : Controller
    {
        private readonly AppDbContext _context;

        public ContactMessagesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var messages = _context.ContactMessages.ToList();
            return View(messages);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                _context.ContactMessages.Add(message);
                await _context.SaveChangesAsync();

                TempData["Message"] = "הפנייה נשמרה בהצלחה!";
                return RedirectToAction(nameof(Index));
            }

            return View(message);
        }
    }
}