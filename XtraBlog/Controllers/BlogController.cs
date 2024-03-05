using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using XtraBlog.DAL;
using XtraBlog.Model;
using XtraBlog.VM;

namespace XtraBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationContext _context;

        public BlogController(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        public IActionResult Detail(string? slug)
        {
            Post post=_context.Posts
             .Include(p=>p.TagPost)
                .ThenInclude(p=>p.Tags)
                .Include(p=>p.Comments)
                .FirstOrDefault(p => p.Slug == slug);
            int[] tagIds = post.TagPost.Select(x => x.TagsID).ToArray();
            ViewBag.Relateds = _context.Posts
                            .Include(x => x.TagPost)
                            .Where(x => x.TagPost.Any(x => tagIds.Contains(x.TagsID)))
                            .ToList();
            if (post == null) NotFound();

            ViewModel viewModel = new ViewModel()
            {
                Post = post
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendComment(string? slug,Comments com) 
        {
            Post post = _context.Posts
             .Include(p => p.TagPost)
                .ThenInclude(p => p.Tags)
                .Include(p => p.Comments)
                .FirstOrDefault(p => p.Slug == slug);
           ViewModel model = new ViewModel()
            {
                Post = post,
               comments = com,
            };
            if (post is null) return NotFound();
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill all box";
                return RedirectToAction("Detail",new { slug=post.Slug});
            }
           
            post.Comments = new List<Comments>();
           post.Comments.Add(com);
            _context.SaveChanges();
           //string url= Request.Headers["Referer"].ToString();
            TempData["Succes"] = "Your comment sent succesfully";
            return RedirectToAction("Detail", new { slug = post.Slug });
        }
        
    }
}
