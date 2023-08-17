using Business.Layer.Contrete;
using Business.Layer.Interface;
using DataAccess.Layer;
using DataAccess.Layer.Contrete;
using DataAccess.Layer.Entity;
using DataAccess.Layer.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IGenericRepository1<Customer>, GenericRepository<Customer>>();
builder.Services.AddScoped<IGenericBusiness<Customer>, GenericBusiness<Customer>>();

builder.Services.AddScoped<IGenericRepository1<Product>, GenericRepository<Product>>();
builder.Services.AddScoped<IGenericBusiness<Product>, GenericBusiness<Product>>();
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
