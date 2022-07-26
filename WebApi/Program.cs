using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers;
using DataAccess.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));

// Add services to the container.

builder.Services.AddControllers();


//builder.Services.AddDbContext<SchoolDbContext>(x =>
//{
//    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"), option =>
//    {
//        option.MigrationsAssembly(Assembly.GetAssembly(typeof(SchoolDbContext)).GetName().Name);
//    });
//});

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        b => b.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();