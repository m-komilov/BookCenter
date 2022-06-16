using BookCenter.Api.Extensions;
using BookCenter.Data.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddCustomServices();
builder.Services.AddHttpContextAccessor();

// calling exampleDbContext
builder.Services.AddDbContext<BookCenterDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiDatabase"))
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

////calling Services
//using (var scope = app.Services.CreateScope())
//{
//    var dataContext = scope.ServiceProvider.GetRequiredService<BookCenterDbContext>();
//    dataContext.Database.Migrate();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
