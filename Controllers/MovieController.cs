using CodeFirstBasic.Context;
using CodeFirstBasic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers
{
    public class MovieController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public MovieController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {

            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}
