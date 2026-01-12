using FitnessMVC.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TrainerController : Controller
    {
       private readonly FitnessDbContext _context;

        public TrainerController(FitnessDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var trainers=_context.Traniers.Include(x => x.Category).ToList();
            return View(trainers);
        }
    }
}
