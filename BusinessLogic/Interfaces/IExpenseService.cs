using Models.RequestModels;
using Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IExpenseService
    {
        Task<ExpenseResponse> AddExpenseAsync(CreateExpenseRequest request);
        Task<IEnumerable<ExpenseResponse>> GetAllExpensesAsync();
        Task<ExpenseResponse?> GetExpenseByIdAsync(int id);
        Task<bool> DeleteExpenseAsync(int id);
    }

}
