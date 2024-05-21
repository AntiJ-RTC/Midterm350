using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Midterm350.Data;

namespace Midterm350.Components
{
    public class VetMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public VetMenuViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vet = await _context.Vets.ToListAsync();
            return View(vet);
        }
    }
}
