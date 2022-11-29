global using FastEndpoints;
using FastEndpoints.Swagger;
using FstEndPntsSample.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDoc();
builder.Services.AddFastEndpoints();
builder.Services.AddSingleton<IStuffService, StuffService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(x => x.ConfigureDefaults());
app.Run();