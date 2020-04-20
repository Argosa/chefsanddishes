using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;


namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db;

        public HomeController(MyContext context)
        {
            db = context;
        }

        public List<Chef> CallingAllChefs()
        {
            List<Chef> AllChefs = db.Chefs.ToList();
            return AllChefs;
        }
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("AddChef")]
        public IActionResult AddChef(Chef chef) 
        {
            if(ModelState.IsValid)
            {
                int age = DateTime.Today.Year - chef.DateOfBirth.Year;

                if(age < 18)
                {
                    ModelState.AddModelError("DateOfBirth", "Chefs are required to be 18");
                    return View("index");
                }

                if(db.Chefs.Any(c => c.FirstName == chef.FirstName && c.LastName == chef.LastName )) 
                {
                    ModelState.AddModelError("FirstName", "Two chefs can't have the same name!");
                    return View("Index");
                }

                Console.WriteLine("Passed 1");

                chef.CreatedAt = DateTime.Now;
                chef.UpdatedAt = DateTime.Now;

                db.Add(chef);

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpGet("NewDish")]

        public IActionResult NewDish() 
        {
            ViewBag.AllChefs = CallingAllChefs();
            return View();
        }

        [HttpPost("CreateDish")]
        public IActionResult CreateDish(Dish dish)
        {
            if(ModelState.IsValid)
            {
                if(dish.Calories < 1)
                {
                    ModelState.AddModelError("Calories", "Calories must be greater than zero!");
                    ViewBag.AllChefs = CallingAllChefs();
                    return View("NewDish");
                }

                if(db.Dishes.Any(d => d.DishName == dish.DishName))
                {
                    ModelState.AddModelError("DishName", "Two dishes cannot have the same names!");
                    return View("NewDish");
                }

                dish.CreatedAt = DateTime.Now;
                dish.UpdatedAt = DateTime.Now;

                db.Add(dish);

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.AllChefs = CallingAllChefs();
            return View("NewDish");
        }

        [HttpGet("AllChefs")]
        public IActionResult AllChefs()
        {
            List<Chef> ChefWithDishes = db.Chefs
                .Include(c => c.CreatedDishes)
                .ToList();

            return View(ChefWithDishes);
        }

        [HttpGet("Chef/{chefId}")]
        public IActionResult ChefDetail(int chefId)
        {
            Chef selectedChef = db.Chefs
                .Include(c => c.CreatedDishes)
                .FirstOrDefault(c => c.ChefID == chefId);
            
            if(selectedChef == null)
            {
                return View("Index");
            }

            ViewBag.CurrentChef = selectedChef;

            int numDishes = db.Chefs
                .Include(c => c.CreatedDishes)
                .FirstOrDefault(c => c.ChefID == chefId)
                .CreatedDishes.Count;

            ViewBag.ChefCount = numDishes;

            return View();
        }

        [HttpGet("AllDishes")]
        public IActionResult AllDishes()
        {
            List<Dish> ChefsForDishes = db.Dishes
                .Include(d => d.Creator)
                .ToList();

                return View(ChefsForDishes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
