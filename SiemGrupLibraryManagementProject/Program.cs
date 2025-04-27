using System;
using System.Reflection;
using SiemGrupLibrary.Business.Abstract;
using SiemGrupLibrary.Business.Concrete;
using SiemGrupLibrary.Business.Mapping;
using SiemGrupLibrary.DataAccess.Context;
using SiemGrupLibrary.DataAccess.EntityFramework;
using SiemGrupLibrary.DataAccess.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<LibraryContext>();
builder.Services.AddAutoMapper(typeof(GeneralMapping));

builder.Services.AddScoped<IAuthorService,AuthorServices>();
builder.Services.AddScoped<IBookService, BookServices>();
builder.Services.AddScoped<IAuthorDal, EfAuthorDal>();
builder.Services.AddScoped<IBookDal, EfBookDal>();


builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
