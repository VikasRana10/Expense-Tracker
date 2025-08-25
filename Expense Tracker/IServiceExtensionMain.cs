using BusinessLogic;
using DataAccess;

namespace Expense_Tracker
{
    public static class IServiceExtensionMain
    {
        public static IServiceCollection AddExpenseTrackerDI(this IServiceCollection services)
        {
            //for now we have just added these two will add Models if required
            services.AddBusinessLogicDI()
                .AddDataAccessDI();

            return services;
        }
    }
}
