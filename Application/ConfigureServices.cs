using Application.PersonOperation.Commands.AddBasketItem;
using Application.Validation.BasketValidator;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace Application
{
    public static class ConfigureServices 
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ConfigureServices));
            services.AddScoped<IValidator<AddBasketItemCommandRequest>, CreateBasketRequestValidator>();

        }

    }
}
