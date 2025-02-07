

using System.Collections.ObjectModel;
using Contexts.UserContext;
using Microsoft.EntityFrameworkCore;

namespace Users.Host
{
    public class Startup
    {
        public void ConfigureService(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<UserContextt>(option=>option.UseSqlServer("data source= ; initialize catalog= ; integrated security= true"));
        }
    }
    
}