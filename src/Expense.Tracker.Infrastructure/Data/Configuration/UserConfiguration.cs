using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expense.Tracker.Infrastructure.Data.Configuration;
internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(k => k.Id);

        builder.HasMany(x => x.Records)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Budgets)
            .WithMany(x => x.Users)
            .UsingEntity(x => x.ToTable("UsersBudgets"));
    }
}
