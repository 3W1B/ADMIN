using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers;

public abstract class UserLoggerController
{
    private static MyDbContext context = new();

    public static async Task Create(UserLogger userLogger)
    {
        context.UserLoggers.Add(userLogger);
        await context.SaveChangesAsync();
    }

    public static async Task<UserLogger> Read(int id)
    {
        return await context.UserLoggers.FindAsync(id);
    }

    public static List<UserLogger> ReadAll()
    {
        return context.UserLoggers.ToList();
    }

    public static async Task Update(UserLogger userLogger)
    {
        context.UserLoggers.Update(userLogger);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(UserLogger userLogger)
    {
        context.UserLoggers.Remove(userLogger);
        await context.SaveChangesAsync();
    }
    
    
}
