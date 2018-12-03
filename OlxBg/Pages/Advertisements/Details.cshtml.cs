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
    public class DetailsModel : PageModel
    {
        private readonly OlxBgContext _context;

        public DetailsModel(OlxBgContext context)
        {
            _context = context;
        }

        public Advert Advert { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            Advert = await _context.Advert.FirstOrDefaultAsync(m => m.ID == id);
            Advert.Cat = (await _context.Categories.FindAsync(int.Parse(Advert.Cat))).Title;

            if (Advert == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
