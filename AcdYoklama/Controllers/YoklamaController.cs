using AcdYoklama.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AcdYoklama.Controllers
{
    public class YoklamaController : Controller
    {

        private readonly EmployeeDbContext _context;

        public YoklamaController(EmployeeDbContext context)
        {
           this. _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Yoklamas = _context.Yoklama.ToList();
            return View(Yoklamas);
        }
    }
}
