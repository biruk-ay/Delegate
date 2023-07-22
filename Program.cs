// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();
using Microsoft.Extensions.Configuration;
using Npgsql;

// ...

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

var connectionString = config.GetConnectionString("MyPostgresConnection");
using var connection = new NpgsqlConnection(connectionString);
connection.Open();
using var command = new NpgsqlCommand("SELECT * FROM clients;", connection);
using var reader = command.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["first_name"]);    
}

connection.Close();