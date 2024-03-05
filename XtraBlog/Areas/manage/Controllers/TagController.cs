using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using XtraBlog.DAL;
using XtraBlog.Model;

namespace XtraBlog.Areas.manage.Controllers
{
        [Area("manage")]
        [Authorize]
    public class TagController : Controller
    {
        private readonly ApplicationContext _context;
        public TagController(ApplicationContext context)
        {
            _context = context;
        }
     
        public IActionResult Index()
        {
            List<Tags> tags = _context.Tag.ToList();

            return View(tags);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Create(Tags tags) 
        { 
            if(!ModelState.IsValid) return View(tags);
            if(_context.Tag.Any(x=>x.Name==tags.Name)) 
            {
                ModelState.AddModelError("Name", "This tags already exists");
                return View();
            }
            _context.Tag.Add(tags);
            _context.SaveChanges();
            TempData["Message"] = "Tag has been created successfully";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            Tags tags = _context.Tag.Find(id);
            if (tags is null) return NotFound();
            return View(tags);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tags tag)         
        {
            if (!ModelState.IsValid) return View();
            if(_context.Tag.Where(x=>x.Id!=tag.Id).Any(x=>x.Name==tag.Name)) 
            {
                ModelState.AddModelError("Name", "this tag already exists");
                return View();  
            }
            _context.Tag.Update(tag);
            _context.SaveChanges();
            TempData["Message"]= "Tag has been updated successfully";
            return  RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id)
        {

            try
            {
                Tags tags = _context.Tag.Find(id);
                if (!ModelState.IsValid) return NotFound();
                _context.Tag.Remove(tags);
                _context.SaveChanges();
                return Json(new
                {
                    Message = "This tag has been deleted",
                    Code = 204
                }); 
            }
            catch(Exception)
            {
                return Json(new
                {
                    Message = "This tag not found",
                    Code = 500
                });

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
