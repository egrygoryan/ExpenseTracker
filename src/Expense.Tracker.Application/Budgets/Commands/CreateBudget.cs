using Expense.Tracker.Domain.Models.Constants;
using MediatR;

namespace Expense.Tracker.Application.Budgets.Commands;
public record CreateBudget(
    string Label,
    decimal Balance,
    Currency Currency,
    int CreatorId) : IRequest<int>;
