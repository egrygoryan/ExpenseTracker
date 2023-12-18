using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expense.Tracker.Infrastructure.Data.Configuration;
internal class RecordConfiguration : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder.HasKey(k => k.Id);

        builder.Property(x => x.Date).HasPrecision(3);

        builder.Property(x => x.Amount).HasPrecision(11, 2);

        builder.HasOne(x => x.User)
            .WithMany(x => x.Records)
            .HasForeignKey(x => x.UserId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
