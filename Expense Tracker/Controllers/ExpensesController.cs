using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.RequestModels;

namespace Expense_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        
            private readonly IExpenseService _expenseService;

            public ExpensesController(IExpenseService expenseService)
            {
                _expenseService = expenseService;
            }

            // GET: api/expenses
            [HttpGet]
            public async Task<IActionResult> GetAllExpenses()
            {
                var expenses = await _expenseService.GetAllExpensesAsync();
                return Ok(expenses);
            }

            // GET: api/expenses/{id}
            [HttpGet("{id}")]
            public async Task<IActionResult> GetExpenseById(int id)
            {
                var expense = await _expenseService.GetExpenseByIdAsync(id);
                if (expense == null)
                    return NotFound();

                return Ok(expense);
            }

            // POST: api/expenses
            [HttpPost]
            public async Task<IActionResult> AddExpense([FromBody] CreateExpenseRequest request)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var expense = await _expenseService.AddExpenseAsync(request);
                return CreatedAtAction(nameof(GetExpenseById), new { id = expense.Id }, expense);
            }

            // DELETE: api/expenses/{id}
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteExpense(int id)
            {
                var result = await _expenseService.DeleteExpenseAsync(id);
                if (!result)
                    return NotFound();

                return NoContent();
            }
        }
}

