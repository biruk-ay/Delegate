using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using delegateBack.Models;
using System;
using System.Linq;

namespace delegateBack.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new UsersDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<UsersDbContext>>()))
        {
            // Look for any movies.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            context.User.AddRange(
                new Users
                {
                    Id = "ijerqioqwj",
                    Name = "a;klwepo",
                    Role = "0iorw0ef",
                    Email = "tresrp0owe0",
                    Password = "'f;dgdsdf1"
                },
                new Users
                {
                    Id = "When Harry Met Sally",
                    Name = "sre",
                    Role = "Romantic Comedy",
                    Email = "tres",
                    Password = "dsdf1"
                }
            );
            context.SaveChanges();
        }
    }
}