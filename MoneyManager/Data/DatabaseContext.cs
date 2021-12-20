using Microsoft.EntityFrameworkCore;
using MoneyManager.Models;

namespace MoneyManager.Data
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
