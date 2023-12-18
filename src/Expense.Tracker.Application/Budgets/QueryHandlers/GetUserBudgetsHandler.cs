using Expense.Tracker.Application.Budgets.Queries;
using Expense.Tracker.Application.DTO;
using Expense.Tracker.Application.Interfaces;
using MediatR;

namespace Expense.Tracker.Application.Budgets.QueryHandlers;
public class GetUserBudgetsHandler : IRequestHandler<GetUserBudgets, IEnumerable<BudgetDTO>>
{
    private readonly IBudgetRepository _repo;

    public GetUserBudgetsHandler(IBudgetRepository repo) => _repo = repo;

    public async Task<IEnumerable<BudgetDTO>> Handle(GetUserBudgets request, CancellationToken cancellationToken)
    {
        var budgets = await _repo.GetUserBudgets(request.UserId);

        var result = budgets.Aggregate(new List<BudgetDTO>(), (budgetsList, budget) =>
        {
            budgetsList.Add(new BudgetDTO(
                Id: budget.Id,
                Label: budget.Label,
                Currency: budget.Currency,
                Balance: budget.Balance,
                OwnerId: budget.OwnerId));

            return budgetsList;
        });

        return result;
    }
}
