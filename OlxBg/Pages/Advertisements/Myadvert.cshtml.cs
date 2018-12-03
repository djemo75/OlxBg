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
    public class MyadvertModel : PageModel
    {
        private readonly OlxBg.Data.OlxBgContext _context;

        public MyadvertModel(OlxBg.Data.OlxBgContext context)
        {
            _context = context;
        }

        public IList<Advert> Advert { get; set; }
        public IList<Categories> Categories { get; set; }
        public static int Count;
        public async Task OnGetAsync()
        {
            IQueryable<Advert> advertIQ = from s in _context.Advert
                                          select s;
            if (User.IsInRole("Admin"))
            {
            }
            else {
                advertIQ = advertIQ.Where(s => s.Author == this.User.Identity.Name);
            }
            Advert = await advertIQ.AsNoTracking().ToListAsync();
            Categories = await _context.Categories.ToListAsync();
            Count = Advert.Count;
        }
    }
}