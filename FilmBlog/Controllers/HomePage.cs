using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmBlog.Models;

namespace FilmBlog.Controllers
{
   
    public class HomePage : Controller
    {
        DataContext c = new DataContext(); 
        public IActionResult Index()
        {
             ViewBag.d = c.Blogs.Take(8).ToList();
            return View();
        }
       
    }
}
