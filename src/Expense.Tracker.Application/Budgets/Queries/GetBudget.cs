using Expense.Tracker.Application.DTO;
using MediatR;

namespace Expense.Tracker.Application.Budgets.Queries;
public record GetBudget(int Id) : IRequest<BudgetDTO>;
