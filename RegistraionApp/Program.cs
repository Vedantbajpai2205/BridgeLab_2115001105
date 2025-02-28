using BusinessLayer1.Service;
using RepositoryLayer1.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container before Build() is called
builder.Services.AddControllers();
builder.Services.AddScoped<RegisterationBL>(); // Add RegisterationBL to DI container
builder.Services.AddScoped<RegisterationRL>(); // Add RegisterationRL to DI container

var app = builder.Build(); // Now we can build the app after registering services

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
