using Expense.Tracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expense.Tracker.Infrastructure.Data.Configuration;
internal class RecordConfiguration : IEntityTypeConfiguration<Record>
{
    public void Configure(EntityTypeBuilder<Record> builder)
    {
        builder.HasKey(k => k.Id);

        builder.ToTable("Records");
    }
}
