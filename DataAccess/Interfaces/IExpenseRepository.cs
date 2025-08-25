using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IExpenseRepository
    {
        Task AddAsync(ExpenseEntity expense);
        Task<IEnumerable<ExpenseEntity>> GetAllAsync();
        Task<ExpenseEntity?> GetByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
}
