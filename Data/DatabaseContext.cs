using Microsoft.EntityFrameworkCore;
using MovieManagement.Enum;
using MovieManagement.Models;

namespace MovieManagement.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<Income> Incomes { get; set; }
    }
}
