using Microsoft.EntityFrameworkCore;
using Motorsport.Data;
using Motorsport.Repositories.Business;
using Motorsport.Repositories.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MotorsportDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MotorsportConnectionString"));
});
builder.Services.AddScoped<IDriverRepository,DriverRepository>();

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
