using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Business.Mapping;
using ECommerce.Data.Abstract;
using ECommerce.Data.Concrete;
using ECommerce.Data.Concrete.Contexts;
using ECommerce.Data.Concrete.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ECommerceDbContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*
 * 
 * Book ad�nda bir Entity olu�turun. (Base entityden miras als�n, ayr�ca Name, Author, PageCount bilgileri olsun.)
 * Gerekli DTO'lar� olu�turun.
 * Gerekli Service class�n� olu�turun.
 * Gerekli Controller'� olu�turun. 
 * Ve gerekli testleri yap�n.
 * CREATE, GETALL, GETBYID
 * */