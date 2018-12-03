using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OlxBg.Data
{
    public class OlxBgContext : DbContext
    {
        public OlxBgContext (DbContextOptions<OlxBgContext> options)
            : base(options)
        {
        }

        public DbSet<OlxBg.Data.Advert> Advert { get; set; }

        public DbSet<OlxBg.Data.Categories> Categories { get; set; }
    }
}
