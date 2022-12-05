using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace effectory.questionnaire.infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        { }
        }
}
