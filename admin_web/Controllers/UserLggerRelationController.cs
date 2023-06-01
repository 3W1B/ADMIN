using System.Runtime.CompilerServices;
using admin_web.Context;
using admin_web.Entities;

namespace admin_web.Controllers
{
	public abstract class UserLoggerRelationController
	{
		private static MyDbContext context = new();

        public static async Task<string> BreakRelation(User user, Logger logger)
        {
            UserLogger userLoggers = (from uL in context.UserLoggers where uL.UserId == user.Id && uL.LoggerId == logger.Id select uL).First();
            context.UserLoggers.Remove(userLoggers);
            logger.Password = Guid.NewGuid().ToString();
            context.Loggers.Update(logger);
            await context.SaveChangesAsync();
            return logger.Password;
        }
    }
}
