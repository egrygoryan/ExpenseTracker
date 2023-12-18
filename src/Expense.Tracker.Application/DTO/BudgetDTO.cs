using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Application.DTO;
public record BudgetDTO(
    int Id,
    string Label,
    Currency Currency,
    decimal Balance,
    int OwnerId);
