using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Data.DTOs;
using Task.Service;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var constr = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("constr").Value;
builder.Services.AddDbContext<AppDbContext>(builder => builder.UseSqlServer(constr));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddValidatorsFromAssemblyContaining<UserDtoValidator>();
builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();


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
