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
    public class SearchModel : PageModel
    {
        private readonly OlxBg.Data.OlxBgContext _context;

        public SearchModel(OlxBg.Data.OlxBgContext context)
        {
            _context = context;
        }

        public IList<Advert> Advert { get; set; }
        public IList<Categories> Categories { get; set; }
        public static int Count;
        public static string SearchWords;
        public static string CityName;
        public async Task OnGetAsync(string value, string city)
        {
            Advert = _context.Advert
                    .Where(s => s.Title.Contains(value) || s.Address.Contains(city))
                    .ToList();
            Advert.ToList().ForEach(a => a.Cat = _context.Categories.Find(int.Parse(a.Cat)).Title);
            Count = Advert.Count;
            SearchWords = value;
            CityName = city;
            Categories = await _context.Categories.ToListAsync();
        }

    }
}