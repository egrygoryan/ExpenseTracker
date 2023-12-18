using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expense.Tracker.Infrastructure.Data.Configuration;
internal class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.HasKey(k => k.Id);

        builder.Property(x => x.Balance).HasPrecision(11, 2);

        builder.HasMany(x => x.Records)
            .WithOne(x => x.Budget)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Owner)
            .WithOne(x => x.Budget)
            .HasForeignKey<Budget>(x => x.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Users)
            .WithOne(x => x.Budget)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
