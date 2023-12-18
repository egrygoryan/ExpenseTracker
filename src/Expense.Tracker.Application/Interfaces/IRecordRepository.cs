using Expense.Tracker.Domain.Models;

namespace Expense.Tracker.Application.Interfaces;
public interface IRecordRepository
{
    Task<IEnumerable<Record>> GetBudgetRecords(int budgetId);
    Task<Record> GetRecordById(int id);
    Task<int> AddRecord(Record toCreate);
    Task<Record> UpdateRecord(Record toUpdate);
}
