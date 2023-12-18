using Expense.Tracker.Application.Budgets.Commands;
using Expense.Tracker.Application.Interfaces;
using Expense.Tracker.Domain.Models;
using MediatR;

namespace Expense.Tracker.Application.Budgets.CommandHandlers;
public class CreateBudgetHandler : IRequestHandler<CreateBudget, int>
{
    private readonly IBudgetRepository _budgetRepo;
    private readonly IUserRepository _userRepo;

    public CreateBudgetHandler(
        IBudgetRepository budgetRepo,
        IUserRepository userRepo) =>
        (_budgetRepo, _userRepo) = (budgetRepo, userRepo);

    public async Task<int> Handle(CreateBudget request, CancellationToken cancellationToken)
    {
        var creator = await _userRepo.GetUserById(request.CreatorId)
            ?? throw new ApplicationException($"No such budget with id: {request.CreatorId}");

        var budget = new Budget(
                        balance: request.Balance,
                        currency: request.Currency,
                        label: request.Label,
                        owner: creator);

        return await _budgetRepo.AddBudget(budget);
    }
}
