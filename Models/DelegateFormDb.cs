using Microsoft.EntityFrameworkCore;
using delegateBack.Models;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
public class DelegateFormDbContext : DbContext
{
    public DbSet<DelegateForm> DelegateForms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("connectionString");
    }
}