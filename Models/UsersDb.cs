using Microsoft.EntityFrameworkCore;
using delegateBack.Models;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;
public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }
    public DbSet<Users> User { get; set; }

}