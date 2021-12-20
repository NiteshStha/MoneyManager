using Microsoft.AspNetCore.Mvc;
using MovieManagement.Data;
using MovieManagement.Models;

namespace MovieManagement.Controllers
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
            List<Crew> crews = _db.Crews.ToList();
            return View(crews);
        }

        public IActionResult AddCrewMember()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCrewMember(Crew crew)
        {
            _db.Crews.Add(crew);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var crew = _db.Crews.Where(x => x.Id == id).FirstOrDefault();
            return View(crew);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Crew crew)
        {
            _db.Crews.Update(crew);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            Crew? crew = _db.Crews.Find(id);
            if (crew != null)
            {
                _db.Crews.Remove(crew);
                await _db.SaveChangesAsync();
            }
            return Json(new { success = true });
        }
    }
}