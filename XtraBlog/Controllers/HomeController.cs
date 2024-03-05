using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Diagnostics;
using XtraBlog.DAL;
using XtraBlog.Model;
using XtraBlog.Services;
using XtraBlog.VM;

namespace XtraBlog.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationContext _context;
        private readonly LayoutService layoutService;

        public HomeController(ApplicationContext applicationContext,LayoutService service)
        {
        _context = applicationContext;
            layoutService = service;
        }
        public IActionResult Index()
        {
            List<Post> posts = _context.Posts
                .Include(x=>x.TagPost)
                .ThenInclude(x=>x.Tags) 
                .Include(x=>x.Comments)
                .ToList();
            ViewBag.Link = "Home";
            return View(posts);
        }

     public IActionResult About()
        {
            ViewBag.Link = "About";
            return View();
        }

        public IActionResult Contact()
        {
            Setting setting = layoutService.GetSetting();
            ViewBag.Link = "Contact";
            MessageVM vM = new MessageVM()
            {
                setting = setting
            };
            return View(vM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage(Message message)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Something went wrong ";
                return RedirectToAction("Contact");
            }
        _context.Messages.Add(message);
            _context.SaveChanges();
            TempData["Succes"] = "Your message has been sent us ";
            return RedirectToAction("Contact");
        
        }
    }
}