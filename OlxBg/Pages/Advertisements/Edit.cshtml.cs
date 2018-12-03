using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OlxBg.Data;

namespace OlxBg.Pages.Advertisements
{
    public class EditModel : PageModel
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly OlxBg.Data.OlxBgContext _context;
        private int advertId;

        public EditModel(OlxBg.Data.OlxBgContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.hostingEnvironment = environment;
        }

        [BindProperty]
        public Advert Advert { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty]
        public IFormFile Image { set; get; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            Advert = await _context.Advert.FirstOrDefaultAsync(m => m.ID == id);
            if (Advert == null)
            {
                return NotFound();
            }
            if (User.IsInRole("Admin"))
            {
                
            }
            else
            {
                if (Advert.Author != User.Identity.Name)
                {
                    return this.Unauthorized();
                }
            }
            advertId = id;
            this.Categories = new SelectList(_context.Categories.ToList(), "ID", "Title");
            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Image != null)
            {
                var fileName = GetUniqueName(this.Image.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");
                var filePath = Path.Combine(uploads, fileName);
                this.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                this.Advert.ImageName = fileName;
            }
            _context.Advert.Update(Advert);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdvertExists(Advert.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AdvertExists(int id)
        {
            return _context.Advert.Any(e => e.ID == id);
        }

        private string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }
    }
}
