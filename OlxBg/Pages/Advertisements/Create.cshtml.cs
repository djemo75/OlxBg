using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OlxBg.Data;

namespace OlxBg.Pages.Advertisements
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly OlxBgContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public CreateModel(OlxBgContext context, IHostingEnvironment environment)
        {
            this.hostingEnvironment = environment;
            _context = context;
            this.Categories = new SelectList(_context.Categories.ToList(), "ID", "Title");
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Advert Advert { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty]
        public IFormFile Image { set; get; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (this.Image != null)
            {
                var fileName = GetUniqueName(this.Image.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");
                var filePath = Path.Combine(uploads, fileName);
                this.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                this.Advert.ImageName = fileName; // Set the file name
            }
            else {
                var fileName = "no-image.png";
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "Uploads");
                var filePath = Path.Combine(uploads, fileName);
                this.Advert.ImageName = fileName; // Set the file name
            }
            this.Advert.Author = this.User.Identity.Name;
            _context.Advert.Add(this.Advert);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
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