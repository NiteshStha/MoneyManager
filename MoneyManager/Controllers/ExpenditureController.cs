using Microsoft.AspNetCore.Mvc;
using MoneyManager.Data;
using MoneyManager.Models;

namespace MoneyManager.Controllers
{
    public class ExpenditureController : Controller
    {
        private readonly DatabaseContext _db;

        public ExpenditureController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Expenditure> expenses = _db.Expenditures.ToList();
            return View(expenses);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Expenditure expenditure)
        {
            _db.Expenditures.Add(expenditure);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}