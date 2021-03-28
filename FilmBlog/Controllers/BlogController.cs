using FilmBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FilmBlog.Controllers
{

    public class BlogController : Controller
    {
        readonly DataContext c = new DataContext();
        
        public IActionResult Index()
        {
            var bloglar = c.Blogs.ToList();
            ViewBag.deger = c.Blogs.OrderByDescending(id => id).Take(5).ToList();
            return View(bloglar);
        }
        public IActionResult Index1(int id)
        {
            var blogbul = c.Blogs.Where(x => x.Id == id).ToList();
            return View(blogbul);
        }
        [HttpPost]
        public async Task<IActionResult> Index(string BlogSearch)

        {
            {
                ViewData["GetBlogs"] = BlogSearch;

                var blogquery = from x in c.Blogs select x;
                if (!string.IsNullOrEmpty(BlogSearch))
                {
                    blogquery = blogquery.Where(x => x.BlogName.Contains(BlogSearch));
                }

                return View(await blogquery.AsNoTracking().ToListAsync());
            }




        }
    }
}

