using Microsoft.AspNetCore.Mvc;
using MoneyManager.Data;
using MoneyManager.Models;

namespace MoneyManager.Controllers
{
    public class IncomeController : Controller
    {
        private readonly DatabaseContext _db;

        public IncomeController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Income> incomes = _db.Incomes.ToList();
            return View(incomes);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Income income)
        {
            _db.Incomes.Add(income);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}