using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expense.Tracker.Infrastructure.Data.Configuration;
internal class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.HasKey(k => k.Id);

        builder.HasMany(x => x.Records)
            .WithOne(x => x.Budget)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Budgets");
    }
}
