using Expense.Tracker.Application.Budgets.Commands;
using Expense.Tracker.Application.DTO;
using Expense.Tracker.Application.Interfaces;
using MediatR;

namespace Expense.Tracker.Application.Budgets.CommandHandlers;
public class UpdateBudgetHandler : IRequestHandler<UpdateBudget, BudgetDTO>
{
    private readonly IBudgetRepository _repo;

    public UpdateBudgetHandler(IBudgetRepository repo) => _repo = repo;

    public async Task<BudgetDTO> Handle(UpdateBudget request, CancellationToken cancellationToken)
    {
        var existingEntity = await _repo.GetBudgetById(request.Id)
            ?? throw new ApplicationException($"No such budget with id: {request.Id}");

        existingEntity.UpdateLabel(request.NewLabel);
        var updatedEntity = await _repo.UpdateBudget(existingEntity);

        return new BudgetDTO(
            Id: updatedEntity.Id,
            Label: updatedEntity.Label,
            Currency: updatedEntity.Currency,
            Balance: updatedEntity.Balance,
            OwnerId: updatedEntity.OwnerId);
    }
}
