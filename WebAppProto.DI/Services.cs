using Microsoft.Extensions.DependencyInjection;
using System;
using WebAppProto.Application;
using WebAppProto.Data.Mapper;
using WebAppProto.Data.Repository;
using WebAppProto.Domain.Application;
using WebAppProto.Domain.Data.IRepository;

namespace WebAppProto.DI
{
    public class Services
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationClient, ApplicationClient>();
            services.AddScoped<IRepoClient, RepoClient> ();
            services.AddScoped<IClientMapper, ClientMapper>();
        }
    }
}
