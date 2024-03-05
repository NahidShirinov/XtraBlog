using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using XtraBlog.DAL;
using XtraBlog.Extension;
using XtraBlog.Model;

namespace XtraBlog.Areas.manage.Controllers
{
    [Area("manage")]
    [Authorize]
    public class BlogController : Controller
    {

        private readonly ApplicationContext _context;
        private readonly IWebHostEnvironment _environment;

        public BlogController(ApplicationContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            List<Post> posts = _context.Posts
                .Include(x=>x.TagPost)
                .ThenInclude(x=>x.Tags)
                .ToList();
            return View(posts);
        }

        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tag.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(Post post)
        {
            ViewBag.Tags = _context.Tag.ToList();
            if (!ModelState.IsValid) return View(post);
            if (post.FormFile is null)
            {
                ModelState.AddModelError("FormFile", "File is required");
                return View(post);
            }

            if (!post.FormFile.ContentType("image"))
                ModelState.AddModelError("FormFile", "This type file not supported image ");
            if (post.FormFile.CheckLength(300))
                ModelState.AddModelError("FormFile", "Fayl çox böyükdür.");
            if (!ModelState.IsValid) return View(post);





            post.Image = await post.FormFile.Fileupload(_environment, "uploads/posts");
            post.Slug = post.Title.Trim().Replace(" ", " - ");
            _context.Posts.Add(post);
            post.TagPost = new List<TagPost>();
            foreach(int tagid in post.TagIds)
            {
                post.TagPost.Add(new TagPost
                {
                    TagsID = tagid
                });

                
            }


            await _context.SaveChangesAsync();
            TempData["Message"] = "Post created succesfully";
            return RedirectToAction("Index");

            

        }


        public async Task<IActionResult>Delete(int? id)
        {
           
            Post post = _context.Posts.Include(x=>x.TagPost).FirstOrDefault(x => x.Id == id);
            if (post is null) return NotFound();
            try
            {
                foreach(TagPost tagPost in post.TagPost)
                {
                    _context.TagPosts.Remove(tagPost);

                }
                _context.Posts.Remove(post);
                string FilePath = Path.Combine(_environment.WebRootPath, "Uploads", "Posts", post.Image ?? "");
                if(System.IO.File.Exists(FilePath))
                {
                    System.IO.File.Delete(FilePath);
                }
                await _context.SaveChangesAsync();
                return Json(new
                {
                    Message = "Post has been deleted",
                    code = 204
                });
            }
            catch (Exception)
            {
                return Json(new
                {
                    Message = "Post Not found",
                    code = 500
                });

            }

        }


        public async Task<IActionResult>Edit(int? id)
        {
            ViewBag.Tags = _context.Tag.ToList();
            Post post=_context.Posts.Include(x=>x.TagPost).FirstOrDefault(x=>x.Id==id);
            if (post is null) return NotFound();
            return View(post);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id,Post post)
        {
                Post postdb =  _context.Posts
                    .Include(x => x.TagPost)
                    .ThenInclude(x=>x.Tags)
                    .FirstOrDefault(x => x.Id==id);
                if (postdb is null) return View(post);
                if (!ModelState.IsValid) return View(post);           
                List<int>tagId=postdb.TagPost.Select(x=>x.TagsID).ToList();
                List<int> AddTagid = post.TagIds.Where(x => tagId.Any(y => y != x)).ToList();
                postdb.TagPost.RemoveAll(x => !post.TagIds.Contains(x.TagsID));
                foreach (int Tagid in AddTagid)
                {
                    postdb.TagPost.Add( new TagPost
                    {

                            TagsID = Tagid
                    }) ;
                }

          if(post.FormFile != null)
            {
                //if (post.FormFile is null)
                //{
                //    ModelState.AddModelError("FormFile", "File is required");
                //    return View(post);
                //}


                if (!post.FormFile.ContentType("image"))
                    ModelState.AddModelError("FormFile", "This type file not supported image ");
                if (post.FormFile.CheckLength(300))
                    ModelState.AddModelError("FormFile", "Fayl çox böyükdür.");
                if (!ModelState.IsValid) return View(post);
                string FilePath = Path.Combine(_environment.WebRootPath, "Uploads", "Posts", post.Image ?? "");
                if(System.IO.File.Exists(FilePath))
                {
                    System.IO.File.Delete(FilePath);
                }
                postdb.Image = await post.FormFile.Fileupload(_environment, "uploads/posts");
            }

                postdb.Title = post.Title;
                postdb.Created_By = post.Created_By;
                postdb.Description= post.Description;
                await _context.SaveChangesAsync();




            TempData["message"] = "Post has beeen updated";
            return RedirectToAction("Index");

        }


        }
    }

