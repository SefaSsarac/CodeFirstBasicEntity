using CodeFirstBasic.Context;
using CodeFirstBasic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers
{
    public class GameController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public GameController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            var newGame = new GameEntity()
            {
                Name = "World Of Warcraft",
                Platform = "PC",
                Rating = 10
            };
            
            _context.Games.Add(newGame);

            _context.SaveChanges();
            
            return Ok();
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
