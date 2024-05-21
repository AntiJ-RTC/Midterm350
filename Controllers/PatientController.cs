using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Midterm350.Data;
using Midterm350.Models;

namespace Midterm350.Controllers
{
    public class PatientController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PatientController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Patient> patients = _db.Patients.ToList();
            return View(patients);
        }
        [Route("Patient/{id:int}/Species/{species?}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var patient = await _db.Patients.FirstOrDefaultAsync(v => v.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Species,Breed,Age,Medications,MedicalHistory,ImgURL")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _db.Add(patient);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var patient = await _db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Species,Breed,Age,Medications,MedicalHistory,ImgURL")] Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(patient);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.Id))
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
            return View(patient);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var patient = await _db.Patients.FirstOrDefaultAsync(v => v.Id == id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _db.Patients.FindAsync(id);
            if (patient != null)
            {
                _db.Patients.Remove(patient);
            }

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool PatientExists(int id)
        {
            return _db.Patients.Any(p => p.Id == id);
        }
    }
}
