using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quotes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuotesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuotesContext>>()))
            {
                // Look for any movies.
                if (context.Company.Any())
                {
                    return;   // DB has been seeded
                }

                context.Company.AddRange(
                   new Company
                   {
                       User = "JuanS@PalmaSAS.com",
                       Password = "ABCD1234"
                   },
                   new Company
                   {
                       User = "AlejoBarrera@BarrerasDelMundo.com",
                       Password="1234ABCD"
                   }             
                );
                context.SaveChanges();
            }
        }
    }
}
