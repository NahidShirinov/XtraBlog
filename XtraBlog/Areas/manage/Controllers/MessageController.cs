using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using XtraBlog.DAL;
using XtraBlog.Model;
using XtraBlog.Services;

namespace XtraBlog.Areas.manage.Controllers
{
    [Area("manage")]
    [Authorize]
    public class MessageController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IEmailService _emailService;
        public MessageController(ApplicationContext applicationContext, IEmailService _services)
        {
            _context = applicationContext;
            _emailService = _services;
        }
        public IActionResult Index()
        {
            List<Message> message = _context.Messages.ToList();
            return View(message);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            Message message = _context.Messages.FirstOrDefault(x => x.Id == id);
            if (message == null) return NotFound();
            await _emailService.EmailSenderAsync(message.Email, message.Subject, message.Text);
            return View(message);
        }
        public async Task<IActionResult> ChangeSatus(int? id)
        {
            Message message = await _context.Messages.FirstOrDefaultAsync(x => x.Id == id);
            message.IsRead = !message.IsRead;
            _context.SaveChangesAsync();
            await _emailService.EmailSenderAsync(message.Email, message.Subject, message.Text);
            TempData["message"] = "Status has been changed";
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> DeleteMesssage(int id)
        {
            Message message = await _context.Messages.FirstOrDefaultAsync(x=>x.Id==id);
            if (!ModelState.IsValid) return NotFound();
            _context.Messages.Remove(message);
            _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
