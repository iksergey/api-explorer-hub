using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Это API списка контактов",
    });
    opt.OperationFilter<AddDescriptionForGreetingByName>();
});
builder.Services.AddControllers();
builder.Services.AddSingleton<DataContext>();
builder.Services.AddSingleton<ContactStorage>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
