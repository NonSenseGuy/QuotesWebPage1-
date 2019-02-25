using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Quotes.Models
{
    public class QuotesContext : DbContext
    {
        public QuotesContext (DbContextOptions<QuotesContext> options)
            : base(options)
        {
        }

        public DbSet<Quotes.Models.Event> Event { get; set; }
        public DbSet<Quotes.Models.UserCustomer> UserCustomer { get; set; }
        public DbSet<Quotes.Models.Company> Company { get; set; }
    }
}
