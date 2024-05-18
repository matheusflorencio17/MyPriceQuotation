using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyPriceQuotationWebsite.Models;

namespace MyPriceQuotationWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<QuotationModel> quotation { get; set; }
    }
}