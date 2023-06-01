using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers;

public abstract class LogController
{
    private static MyDbContext context = new();

    public static async Task Create(Log log)
    {
        context.Logs.Add(log);
        await context.SaveChangesAsync();
    }

    public static async Task<Log> Read(int id)
    {
        return await context.Logs.FindAsync(id);
    }

    public static List<Log> ReadAll()
    {
        return context.Logs.ToList();
    }

    public static async Task Update(Log log)
    {
        context.Logs.Update(log);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(Log log)
    {
        context.Logs.Remove(log);
        await context.SaveChangesAsync();
    }
    
    
}