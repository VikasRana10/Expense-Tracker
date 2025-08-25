using BusinessLogic.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Models.RequestModels;
using Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<ExpenseResponse> AddExpenseAsync(CreateExpenseRequest request)
        {
            var entity = new ExpenseEntity
            {
                Title = request.Title,
                Amount = request.Amount,
                Category = request.Category,
                Date = request.Date
            };

            await _expenseRepository.AddAsync(entity);

            return new ExpenseResponse
            {
                Id = entity.Id,
                Title = entity.Title,
                Amount = entity.Amount,
                Category = entity.Category,
                Date = entity.Date
            };
        }

        public async Task<IEnumerable<ExpenseResponse>> GetAllExpensesAsync()
        {
            var expenses = await _expenseRepository.GetAllAsync();
            return expenses.Select(e => new ExpenseResponse
            {
                Id = e.Id,
                Title = e.Title,
                Amount = e.Amount,
                Category = e.Category,
                Date = e.Date
            });
        }

        public async Task<ExpenseResponse?> GetExpenseByIdAsync(int id)
        {
            var expense = await _expenseRepository.GetByIdAsync(id);
            if (expense == null) return null;

            return new ExpenseResponse
            {
                Id = expense.Id,
                Title = expense.Title,
                Amount = expense.Amount,
                Category = expense.Category,
                Date = expense.Date
            };
        }

        public async Task<bool> DeleteExpenseAsync(int id)
        {
            return await _expenseRepository.DeleteAsync(id);
        }
    }
}
