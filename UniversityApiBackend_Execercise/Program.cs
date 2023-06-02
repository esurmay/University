//1. Usings to work with EntityFramework
using Microsoft.EntityFrameworkCore;
using UniversityApiBackend_Execercise.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//2. connection with sql server express
const string CONNECTIONSTRING = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONSTRING);

//3. Add Context to services builder
builder.Services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(connectionString));


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
