using Expense.Tracker.Application.DTO;
using MediatR;

namespace Expense.Tracker.Application.Budgets.Commands;
public record UpdateBudget(
    int Id,
    string NewLabel) : IRequest<BudgetDTO>;
