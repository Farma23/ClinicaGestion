using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaGestion.Data;
using ClinicaGestion.Models;

namespace ClinicaGestion.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ClinicaContext _context;
        public PatientsController(ClinicaContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            var patients = await _context.Patients.OrderBy(p => p.FullName).ToListAsync();
            return View(patients);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();
            return View(patient);
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,DateOfBirth,PhoneNumber,Address")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Paciente registrado correctamente.";
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();
            return View(patient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,DateOfBirth,PhoneNumber,Address")] Patient patient)
        {
            if (id != patient.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(patient);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Paciente actualizado correctamente.";
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null) return NotFound();
            return View(patient);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient != null) _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Paciente eliminado correctamente.";
            return RedirectToAction(nameof(Index));
        }
    }
}
