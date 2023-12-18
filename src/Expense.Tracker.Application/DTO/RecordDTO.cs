using Expense.Tracker.Domain.Models.Constants;

namespace Expense.Tracker.Application.DTO;
public record RecordDTO(
    int Id,
    DateTime Date,
    string Note,
    Category Category,
    decimal Amount,
    int? UserId,
    int BudgetId);
