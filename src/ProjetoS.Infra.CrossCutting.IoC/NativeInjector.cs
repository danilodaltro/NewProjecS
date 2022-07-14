using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetoS.Infra.CrossCutting.IoC
{
    public class NativeInjector
    {
        public static void Setup(IServiceCollection services, IConfiguration configuration)
        {
            RegisterServices(services, configuration);
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            
        }
    }
}
