using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ICategoryService, CategoryManager>();

        return services;
    }

   

    
}