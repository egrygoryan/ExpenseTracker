using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Domain.Models;
public class Record : BaseEntity
{
    public Record() { }
    public Record(
        string note,
        Operation operation,
        decimal amount,
        Category category,
        User user,
        Budget budget)
    {
        Note = note;
        Operation = operation;
        Amount = amount;
        Date = DateTime.Now;
        Category = category;
        User = user;
        Budget = budget;
    }

    public DateTime Date { get; private set; }
    public string Note { get; private set; } = string.Empty;
    public Operation Operation { get; private set; }
    public Category Category { get; private set; }
    public decimal Amount { get; private set; }

    public virtual User User { get; private set; }
    public int? UserId { get; private set; }
    public virtual Budget Budget { get; private set; }
}
