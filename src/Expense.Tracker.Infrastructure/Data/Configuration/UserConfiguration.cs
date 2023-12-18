using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expense.Tracker.Infrastructure.Data.Configuration;
internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(k => k.Id);

        builder.HasMany(x => x.Budgets)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
