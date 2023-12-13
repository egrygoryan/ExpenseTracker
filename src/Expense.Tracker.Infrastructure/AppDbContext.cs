using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Expense.Tracker.Infrastructure;
internal class AppDbContext : DbContext
{
    internal AppDbContext(DbContextOptions options) : base(options) { }

    internal DbSet<User> Users { get; set; }
    internal DbSet<Budget> Budgets { get; set; }
    internal DbSet<Record> Records { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
