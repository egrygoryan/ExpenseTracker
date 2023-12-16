using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Application.DTO;
public record BudgetDTO(
    Guid Id,
    Currency Currency,
    decimal Balance);
