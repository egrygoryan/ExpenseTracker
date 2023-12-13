namespace Expense.Tracker.Domain.Models.Constants;

[Flags]
public enum Category
{
    Entertainment = 1 << 0,
    Gifting = 1 << 1,
    Groceries = 1 << 2,
    Household = 1 << 3,
    MedicalAndHealthcare = 1 << 4,
    Purchases = 1 << 5,
    SavingAndInvesting = 1 << 6,
    Transportation = 1 << 7,
    Utilities = 1 << 8,
    Miscellaneous = 1 << 9,
}
