namespace Expense.Tracker.Domain.Models;
public class User : BaseEntity
{
    public string UserName { get; private set; }

    public ICollection<Budget> Budgets { get; } = new List<Budget>();
    public ICollection<Record> Records { get; } = new List<Record>();
    public User(string userName) => UserName = userName;

    public void UpdateUserName(string userName)
    {
        if (string.IsNullOrWhiteSpace(userName))
        {
            throw new InvalidOperationException($"Name can't be null or empty");
        }

        UserName = userName;
    }
    public void AddBudget(Budget budget) => Budgets.Add(budget);
    public void AddRecord(Record record) => Records.Add(record);
}
