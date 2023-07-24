using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using delegateBack.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
builder.Services.AddControllers();
builder.Services.AddDbContext<UsersDbContext> (
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("MyPostgresConnection"))
);
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
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

// ...

// var config = new ConfigurationBuilder()
//     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//     .Build();

// var connectionString = config.GetConnectionString("MyPostgresConnection");
// using var connection = new NpgsqlConnection(connectionString);
// connection.Open();
// using var command = new NpgsqlCommand("SELECT * FROM clients;", connection);
// using var reader = command.ExecuteReader();
// while (reader.Read())
// {
//     Console.WriteLine(reader["first_name"]);    
// }

// connection.Close();