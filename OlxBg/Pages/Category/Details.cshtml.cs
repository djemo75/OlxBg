using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OlxBg.Data;

namespace OlxBg.Pages.Category
{
    [Authorize(Roles = "Admin")]
    public class DetailsModel : PageModel
    {
        private readonly OlxBgContext _context;

        public DetailsModel(OlxBgContext context)
        {
            _context = context;
        }

        public Categories Categories { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categories = await _context.Categories.FirstOrDefaultAsync(m => m.ID == id);

            if (Categories == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
