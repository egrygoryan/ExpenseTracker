using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Domain.Models;
public class Budget : BaseEntity
{
    public Currency Currency { get; }
    public string BudgetName { get; } = "Default";
    private decimal Balance { get; set; }

    public ICollection<Record> Records { get; } = new List<Record>();
    public ICollection<User> Users { get; } = new List<User>();
    public Budget(
        decimal balance,
        Currency currency,
        string budgetName)
    {
        Balance = balance;
        Currency = currency;
        BudgetName = budgetName;
    }

    public void AddFunds(decimal amount) => Balance += amount;
    public void SubtractFunds(decimal amount) => Balance -= amount;
    public decimal GetBalance() => Balance;
    public void AddRecord(Record entry) => Records.Add(entry);
}
