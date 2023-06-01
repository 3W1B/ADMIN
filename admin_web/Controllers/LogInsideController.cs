using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers
{
	public abstract class LogInsideController
	{
		 private static MyDbContext context = new();

    public static async Task Create(LogInside logInside)
    {
        context.LogInsides.Add(logInside);
        await context.SaveChangesAsync();
    }

    public static async Task<LogInside> Read(int id)
    {
        return await context.LogInsides.FindAsync(id);
    }

    public static List<LogInside> ReadAll()
    {
        return context.LogInsides.ToList();
    }

    public static async Task Update(LogInside logInside)
    {
        context.LogInsides.Update(logInside);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(LogInside logInside)
    {
        context.LogInsides.Remove(logInside);
        await context.SaveChangesAsync();
    }	
	}
}
