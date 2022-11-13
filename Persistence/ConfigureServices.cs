using Application.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Concrete;
using Persistence.Contexts;
using Persistence.Intercepter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("BasketOperationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            }

            services.AddScoped<IBasketService, BasketManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IBasketItemService, BasketItemManager>();
            services.AddScoped<EntitySaveChangesInterceptor>();

            return services;
        }
    }
}
