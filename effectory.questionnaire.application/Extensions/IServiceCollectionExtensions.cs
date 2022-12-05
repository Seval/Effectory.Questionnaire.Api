using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
        { }
    }
}
