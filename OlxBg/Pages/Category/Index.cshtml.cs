using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OlxBg.Data;

namespace OlxBg.Pages.Category
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly OlxBgContext _context;

        public IndexModel(OlxBgContext context)
        {
            _context = context;
        }

        public IList<Categories> Categories { get;set; }

        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
        }
    }
}
