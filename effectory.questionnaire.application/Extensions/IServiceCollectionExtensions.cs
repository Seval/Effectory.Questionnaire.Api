using effectory.questionnaire.application.Queries;
using effectory.questionnaire.application.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace effectory.questionnaire.application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = Assembly.GetAssembly(typeof(QuestionsWithPaginationQuery));
            services.AddMediatR(assembly);

            services.AddTransient<IQuestionnaireService, QuestionnaireService>();

        }
    }
}
