using ASP_Exam.Helpers.JwtUtil;
using ASP_Exam.Repositories.MateriiRepo;
using ASP_Exam.Repositories.ProfesoriRepo;
using ASP_Exam.Repositories.UserRepository;
using ASP_Exam.Services;

namespace ASP_Exam.Helpers
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProfesoriRepository, ProfesoriRepository>();
            services.AddTransient<IMateriiRepository, MateriiRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IProfesoriService, ProfesoriService>();
            services.AddTransient<IMateriiService, MateriiService>();

            return services;
        }

        public static IServiceCollection AddHelpers(this IServiceCollection services)
        {
            services.AddTransient<IJwtUtils, JwtUtils>();

            return services;
        }
    }
}
