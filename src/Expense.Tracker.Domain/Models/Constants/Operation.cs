namespace Expense.Tracker.Domain.Models.Constants;

[Flags]
public enum Operation
{
    Income = 1 << 0,
    Expense = 1 << 1
}
