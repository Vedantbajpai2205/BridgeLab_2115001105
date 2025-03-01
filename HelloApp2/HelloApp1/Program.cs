using BusinessLayer.Service;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));

// Add Swagger to container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>(); // Adding dependency injection so objects can be created
builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();
builder.Services.AddScoped(typeof(ILoggerManager<>), typeof(LoggerManager<>));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
