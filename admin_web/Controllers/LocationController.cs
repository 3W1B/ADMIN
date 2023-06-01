using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers
{
	public abstract class LocationController
	{
		private static MyDbContext context = new();

    public static async Task Create(Location location)
    {
        context.Locations.Add(location);
        await context.SaveChangesAsync();
    }

    public static async Task<Location> Read(int id)
    {
        return await context.Locations.FindAsync(id);
    }

    public static List<Location> ReadAll()
    {
        return context.Locations.ToList();
    }

    public static async Task Update(Location location)
    {
        context.Locations.Update(location);
        await context.SaveChangesAsync();
    }

    public static async Task Delete(Location location)
    {
        context.Locations.Remove(location);
        await context.SaveChangesAsync();
    }
	}
}
