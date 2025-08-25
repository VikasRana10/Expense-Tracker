using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class IServiceExtensionModel
    {
        public static IServiceCollection AddModelsDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
