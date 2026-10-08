using Library_Management_System_LMSTest.AllCustoms.BookCustoms;
using Library_Management_System_LMSTest.AllCustoms.CategoryCustoms;
using Library_Management_System_LMSTest.AllCustoms.MemberCustom;
using Library_Management_System_LMSTest.GenaricRepo;
using Library_Management_System_LMSTest.Models;
using Library_Management_System_LMSTest.Unit_Of_Work;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("C")));

builder.Services.AddScoped(typeof(IGenaricRepo<>), typeof(GenaricRepos<>));
builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
builder.Services.AddScoped<IBookRepo , BookRepo>();
builder.Services.AddScoped<ICategoryRepo , CategoryRepo>();
builder.Services.AddScoped<IMemberRepo , MemberRepo>();

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
