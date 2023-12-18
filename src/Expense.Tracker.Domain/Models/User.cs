namespace Expense.Tracker.Domain.Models;
public class User : BaseEntity
{
    public User() { }
    public User(string userName) => UserName = userName;

    public string UserName { get; private set; }
    public virtual Budget Budget { get; private set; }
    public virtual ICollection<Record> Records { get; } = new List<Record>();
    public virtual ICollection<UserBudget> Budgets { get; } = new List<UserBudget>();

    public void UpdateUserName(string userName) => UserName = userName;
}
