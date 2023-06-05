using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers;

public abstract class UserController
{
    private static MyDbContext context = new();

    public static async Task Create(User user)
    {
        String password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
        user.Password = password;

        context.Users.Add(user);
        await context.SaveChangesAsync();
    }

    public static async Task<User> Read(int id)
    {
        return await context.Users.FindAsync(id);
    }

    public static List<User> ReadAll()
    {
        return context.Users.ToList();
    }

    public static async Task Update(User user)
    {
        context.Users.Update(user);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(User user)
    {
        context.Users.Remove(user);
        await context.SaveChangesAsync();
    }
    
}