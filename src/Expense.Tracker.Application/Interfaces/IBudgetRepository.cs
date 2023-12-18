using Expense.Tracker.Domain.Models;

namespace Expense.Tracker.Application.Interfaces;
public interface IBudgetRepository
{
    Task<IEnumerable<Budget>> GetUserBudgets(int userId);
    Task<Budget> GetBudgetById(int id);
    Task<int> AddBudget(Budget toCreate);
    Task<Budget> UpdateBudget(Budget toUpdate);
}
