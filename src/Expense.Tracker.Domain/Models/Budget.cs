using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Domain.Models;
public class Budget : BaseEntity
{
    public Budget() { }
    public Budget(
        decimal balance,
        Currency currency,
        string label,
        User owner)
    {
        Balance = balance;
        Currency = currency;
        Label = label;
        Owner = owner;
    }

    public Currency Currency { get; private set; }
    public string Label { get; private set; } = "Default";
    public decimal Balance { get; private set; }
    public virtual User Owner { get; private set; }
    public int OwnerId { get; private set; }
    public virtual ICollection<Record> Records { get; } = new List<Record>();
    public virtual ICollection<UserBudget> Users { get; } = new List<UserBudget>();

    public void UpdateLabel(string label) => Label = label;
}
