global using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddFastEndpoints();

var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//  app.UseSwaggerGen();
//  app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseFastEndpoints();
app.Run();