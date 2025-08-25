using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class IServiceExtensionBL
    {
        public static IServiceCollection AddBusinessLogicDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
