using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers;

public abstract class LogOutsideController
{
    private static MyDbContext context = new();

    public static async Task Create(LogOutside logOutside)
    {
        context.LogOutsides.Add(logOutside);
        await context.SaveChangesAsync();
    }

    public static async Task<LogOutside> Read(int id)
    {
        return await context.LogOutsides.FindAsync(id);
    }

    public static List<LogOutside> ReadAll()
    {
        return context.LogOutsides.ToList();
    }

    public static async Task Update(LogOutside logOutside)
    {
        context.LogOutsides.Update(logOutside);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(LogOutside logOutside)
    {
        context.LogOutsides.Remove(logOutside);
        await context.SaveChangesAsync();
    }
    
    
}