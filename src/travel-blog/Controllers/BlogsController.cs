using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using travel_blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace travel_blog.Controllers
{
    public class BlogsController : Controller
    {
        private TravelBlogContext db = new TravelBlogContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var thisLocationIds = db.LocationBlogs
                .Include(locations => locations.Locations)
                .Where(p => p.BlogId == id)
                .ToList();

            List<string> Cities = new List<string> { };
 

            foreach (var loc in thisLocationIds) 
            {
                var thisLocation = db.Locations.FirstOrDefault(locate => locate.LocationId == loc.LocationId);
                Cities.Add(thisLocation.City.ToString());
            }
            
           
            var thisEntry = db.Blogs
                .FirstOrDefault(blogs => blogs.BlogId == id);


            ViewBag.LocationStuff = Cities;
            return View(thisEntry);
        }

    }
}
