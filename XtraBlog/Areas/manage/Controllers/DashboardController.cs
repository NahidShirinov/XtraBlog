using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XtraBlog.DAL;
using XtraBlog.Model;

namespace XtraBlog.Areas.manage.Controllers
{
    [Area("manage")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ApplicationContext _context;
        public DashboardController( ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        public IActionResult Index()
        {
          
            
            return View();
        }
        public IActionResult Setting ()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Setting(Setting setting)
        {
            Setting settingDb = _context.Settings.FirstOrDefault();
            if (settingDb == null)
            {
                _context.Settings.Add(setting);
            }
            else
            {
                settingDb.Linkedin = setting.Linkedin;
                settingDb.Facebook = setting.Facebook;
                settingDb.Instagram = setting.Instagram;
                settingDb.Twitter = setting.Twitter;
                settingDb.Email = setting.Email;
                settingDb.Phone = setting.Phone;
            }
            _context.SaveChanges();
            TempData["Message"] = "Settings has been changed";
            return RedirectToAction("Setting");
        }
    }
}
