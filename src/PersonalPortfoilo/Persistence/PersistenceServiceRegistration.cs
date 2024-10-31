using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.EntityConfigurations;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PersonalPortfolio")));

        services.AddScoped<IAboutUserRepository, AboutUserRepository>();
        services.AddScoped<IBlogCommentsRepository, BlogCommentsRepository>();
        services.AddScoped<IBlogPostsRepository, BlogPostsRepository>();
        services.AddScoped<IContactFormMessagesRepository, ContactFormMessagesRepository>();
        services.AddScoped<IUserEducationsRepository, UserEducationsRepository>();
        services.AddScoped<IUserExperiencesRepository, UserExperiencesRepository>();
        services.AddScoped<IUserProjectsRepository, UserProjectsRepository>();
        return services;
    }
}
