using Application;
using Application.Validation;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationService();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ValidatorExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
