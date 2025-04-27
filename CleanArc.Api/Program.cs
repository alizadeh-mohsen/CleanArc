using CleanArc.Infra.Data.Context;
using CleanArc.Infra.IoC;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection; // Add this to resolve the Assembly reference

var builder = WebApplication.CreateBuilder(args);

var universityDbConnectionString = builder.Configuration.GetConnectionString("UniversityDBConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<UniversityDbContext>(options =>
options.UseSqlServer(universityDbConnectionString));



// Specify the assembly explicitly to resolve the ambiguity
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
DependencyContainer.RegisterServices(builder.Services);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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