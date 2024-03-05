using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using XtraBlog.DAL;
using XtraBlog.Model;

namespace XtraBlog.Areas.manage.Controllers
{
        [Area("manage")]
        [Authorize]
    public class CommentController : Controller
    {
        private readonly ApplicationContext _context;
        public CommentController(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        public IActionResult Index()
        {
            List<Comments> comments = _context.Comment.Include(x => x.Post).ToList();

            return View(comments);
        }

        public IActionResult ChangeStatus(int? id)
        {
            Comments comments=_context.Comment.FirstOrDefault(x=>x.Id==id);
            if (comments==null) return NotFound();
            try
            {
                comments.IsVerified=!comments.IsVerified;
                _context.SaveChanges();
                return Json(new
                {
                    Message = "Status has been changed",
                    code = 200
                }); 
            }
            catch (Exception)
            {
                return Json(new
                {
                    Message = "Something went wrong",
                    code=404
                });
                
            }
        }
    }
}
