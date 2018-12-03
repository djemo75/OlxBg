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
    public class AlladvertModel : PageModel
    {
        private const int advertPerPage = 3;
        private readonly OlxBg.Data.OlxBgContext _context;

        public AlladvertModel(OlxBg.Data.OlxBgContext context)
        {
            _context = context;
        }

        public IList<Advert> Advert { get; set; }
        public IList<Categories> Categories { get; set; }
        public int PageIndex { get; set; }
        public bool HasNextPage { get; set; }

        public async Task OnGetAsync(int pageIndex = 1)
        {
            PageIndex = pageIndex;
            HasNextPage = Math.Floor(_context.Advert.Count() / (double)advertPerPage) > PageIndex;
            Advert = await _context.Advert
                .OrderByDescending(a => a.ID)
                .Skip((pageIndex - 1) * advertPerPage)
                .Take(advertPerPage)
                .ToListAsync();
            Categories = await _context.Categories.ToListAsync();
        }
    }
}