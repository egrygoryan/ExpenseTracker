namespace Expense.Tracker.Domain.Models.Constants;

[Flags]
public enum Currency
{
    USD = 1 << 0,
    Euro = 1 << 1,
    HRN = 1 << 2,
}
