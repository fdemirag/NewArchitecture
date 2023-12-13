using System.Reflection;
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
        services.AddScoped<ICustomerService, CustomerManager>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }


    public static IServiceCollection AddSubClassesOfType(
this IServiceCollection services,
Assembly assembly,
Type type,
Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null
)
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (var item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item);

            else
                addWithLifeCycle(services, type);
        return services;
    }

}
//customer companyname contact name  city country 5 kolon customers tablo full crud
//kural contact name tekrar edemez , bir şehirden max 10 müşteri olabilir 

    
