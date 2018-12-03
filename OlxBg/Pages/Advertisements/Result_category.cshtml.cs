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
    public class Result_categoryModel : PageModel
    {
        private readonly OlxBgContext _context;

        public Result_categoryModel(OlxBgContext context)
        {
            _context = context;
        }
        
        public Categories Categories { get; set; }
        public IList<Advert> Advert { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            Categories = await _context.Categories.FirstOrDefaultAsync(m => m.ID == id);
            IQueryable<Advert> advertIQ = from s in _context.Advert
                                          select s;
            advertIQ = advertIQ.OrderByDescending(a => a.ID).Where(s => s.Cat == id.ToString());
            Advert = await advertIQ.AsNoTracking().ToListAsync();

            if (Categories == null)
            {
                return NotFound();
            }
            return Page();

        }
    }
}