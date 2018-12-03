using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OlxBg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlxBg.Data
{
    public static class SeedCategory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OlxBgContext(
                serviceProvider.GetRequiredService<DbContextOptions<OlxBgContext>>()))
            {
                // Look for any movies.
                if (context.Categories.Any())
                {
                    return;   // DB has been seeded
                }

                context.Categories.AddRange(
                    new Categories
                    {
                        Title = "Недвижими имоти",
                    },
                    new Categories
                    {
                        Title = "Автомобили,каравани,лодки",
                    },
                    new Categories
                    {
                        Title = "Електроника",
                    },
                    new Categories
                    {
                        Title = "Спорт,книги,xоби",
                    },
                    new Categories
                    {
                        Title = "Животни",
                    },
                    new Categories
                    {
                        Title = "Дом и градина",
                    },
                    new Categories
                    {
                        Title = "Мода",
                    },
                    new Categories
                    {
                        Title = "За бебето и детето",
                    },
                    new Categories
                    {
                        Title = "Екскурзии,почивки",
                    },
                    new Categories
                    {
                        Title = "Услуги",
                    },
                    new Categories
                    {
                        Title = "Машини,инструменти,бизнес оборудване",
                    },
                    new Categories
                    {
                        Title = "Работа",
                    },
                    new Categories
                    {
                        Title = "Подарявам",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
