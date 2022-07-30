using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.General
{
    public class DependencyInjection
    {
        public void Config(IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
