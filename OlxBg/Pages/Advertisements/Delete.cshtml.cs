using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OlxBg.Data;

namespace OlxBg.Pages.Advertisements
{
    public class DeleteModel : PageModel
    {
        private readonly OlxBg.Data.OlxBgContext _context;

        public DeleteModel(OlxBg.Data.OlxBgContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Advert Advert { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Advert = await _context.Advert.FirstOrDefaultAsync(m => m.ID == id);

            if (Advert == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Advert = await _context.Advert.FindAsync(id);

            if (Advert != null)
            {
                _context.Advert.Remove(Advert);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
