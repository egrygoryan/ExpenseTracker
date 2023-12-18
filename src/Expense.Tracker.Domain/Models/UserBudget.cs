namespace Expense.Tracker.Domain.Models;
public class UserBudget : BaseEntity
{
    public User User { get; set; }
    public Budget Budget { get; set; }
}
