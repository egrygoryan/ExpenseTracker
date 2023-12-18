using Expense.Tracker.Application.Budgets.Queries;
using Expense.Tracker.Application.DTO;
using Expense.Tracker.Application.Interfaces;
using MediatR;

namespace Expense.Tracker.Application.Budgets.QueryHandlers;
public class GetBudgetHandler : IRequestHandler<GetBudget, BudgetDTO>
{
    private readonly IBudgetRepository _repo;

    public GetBudgetHandler(IBudgetRepository repo) => _repo = repo;

    public async Task<BudgetDTO> Handle(GetBudget request, CancellationToken cancellationToken)
    {
        var budget = await _repo.GetBudgetById(request.Id)
            ?? throw new ApplicationException($"No such budget with id: {request.Id}");

        return new BudgetDTO(
            Id: budget.Id,
            Label: budget.Label,
            Currency: budget.Currency,
            Balance: budget.Balance,
            OwnerId: budget.OwnerId);
    }
}
