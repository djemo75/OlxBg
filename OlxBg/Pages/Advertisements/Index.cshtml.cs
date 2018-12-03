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
    public class IndexModel : PageModel
    {
        private readonly OlxBg.Data.OlxBgContext _context;

        public IndexModel(OlxBg.Data.OlxBgContext context)
        {
            _context = context;
        }

        public IList<Advert> Advert { get;set; }
        public IList<Categories> Categories { get; set; }
        
        public async Task OnGetAsync()
        {
            Advert = await _context.Advert
                .OrderByDescending(a => a.ID)
                .Take(20)
                .ToListAsync();
            Categories = await _context.Categories.ToListAsync();
        }
    }
}
