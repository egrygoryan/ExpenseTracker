using Expense.Tracker.Domain.Models;

namespace Expense.Tracker.Application.Interfaces;
public interface IUserRepository
{
    Task<User> GetUserById(int id);
    Task<int> AddUser(User toCreate);
    Task<User> UpdateUser(User toUpdate);
}
