using eShangdian.Models.Entities;
using System.Linq;

namespace eShangdian.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            if (context.Admins.Any())
            {
                return;
            }

            context.Admins.Add(new Admin()
            {
                Password = "admin",
                Ip = "",
                RegisterDate = System.DateTime.Now
            });
        }
    }
}
