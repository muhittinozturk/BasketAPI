using FluentValidation;
using Microsoft.AspNetCore.Http;
using System.Reflection;

namespace Application.Validation
{
    public class ValidatorExceptionMiddleware
    {
        private readonly RequestDelegate _request;

        public ValidatorExceptionMiddleware(RequestDelegate request)
        {
            _request = request;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _request(context);
            }
            catch (ValidationException exception)
            {
                var messageStr = "";
                context.Response.StatusCode = 400;
                var messages = exception.Errors.Select(x => x.ErrorMessage).ToList();
                foreach(var message in messages)
                {
                    messageStr += message; 
                }

                await context.Response.WriteAsync(messageStr);
            }
        }
    }
}
