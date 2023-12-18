using Expense.Tracker.Application.DTO;
using MediatR;

namespace Expense.Tracker.Application.Budgets.Queries;
public record GetUserBudgets(int UserId) : IRequest<IEnumerable<BudgetDTO>>;
