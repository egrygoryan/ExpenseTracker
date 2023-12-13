using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Domain.Models;
public class Record : BaseEntity
{
    private decimal _amount;
    public DateTime Date { get; }
    public string Note { get; } = string.Empty;
    public Operation Operation { get; }
    public Category Category { get; }
    public User? User { get; }
    public Budget Budget { get; }
    public decimal Amount
    {
        get { return _amount; }
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException(
                    $"You can't provide less or equal to zero value for a record");
            }

            _amount = value;
        }
    }

    public Record(
        string note,
        Operation operation,
        decimal amount,
        Category category,
        User? user,
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
}
