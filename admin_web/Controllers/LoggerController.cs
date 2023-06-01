using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers;

public abstract class LoggerController
{
    private static MyDbContext context = new();

    public static async Task Create(Logger logger)
    {
        context.Loggers.Add(logger);
        await context.SaveChangesAsync();
    }

    public static async Task<Logger> Read(string id)
    {
        return await context.Loggers.FindAsync(id);
    }

    public static List<Logger> ReadAll()
    {
        return context.Loggers.ToList();
    }

    public static async Task Update(Logger logger)
    {
        context.Loggers.Update(logger);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(Logger logger)
    {
        context.Loggers.Remove(logger);
        await context.SaveChangesAsync();
    }
    
    
}
