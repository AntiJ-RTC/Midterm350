using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Midterm350.Data;
using Midterm350.Models;

namespace Midterm350.Controllers
{
    public class VetController : Controller
    {
        private readonly ApplicationDbContext _db;
        public VetController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Veterinarian> vetList = _db.Vets.ToList();
            return View(vetList);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vet = await _db.Vets.FirstOrDefaultAsync(v => v.Id == id);
            if (vet == null)
            {
                return NotFound();
            }
            return View(vet);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,YearsExperience,Bio,ImgURL")] Veterinarian vet)
        {
            if (ModelState.IsValid)
            {
                _db.Add(vet);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vet);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vet = await _db.Vets.FindAsync(id);
            if (vet == null)
            {
                return NotFound();
            }
            return View(vet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,YearsExperience,Bio,ImgURL")] Veterinarian vet)
        {
            if(id != vet.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(vet);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VetExists(vet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vet);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var vet = await _db.Vets.FirstOrDefaultAsync(v => v.Id == id);
            if (vet == null)
            {
                return NotFound();
            }
            return View(vet);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vet = await _db.Vets.FindAsync(id);
            if(vet != null) 
            { 
                _db.Vets.Remove(vet);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool VetExists(int id)
        {
            return _db.Vets.Any(vet => vet.Id == id);
        }
    }
}
