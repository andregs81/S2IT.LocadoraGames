using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using S2IT.LocadoraGames.Application.Interfaces;
using S2IT.LocadoraGames.Application.Services;
using S2IT.LocadoraGames.Domain.Interfaces.Repository;
using S2IT.LocadoraGames.Domain.Interfaces.Services;
using S2IT.LocadoraGames.Domain.Services;
using S2IT.LocadoraGames.Infra.Data.Context;
using S2IT.LocadoraGames.Infra.Data.Repository;

namespace S2IT.LocadoraGames.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IAmigoAppService, AmigoAppService>();
            services.AddScoped<IJogoAppService, JogoAppService>();
            services.AddScoped<IEnderecoAppService, EnderecoAppService>();


            //Service
            services.AddScoped<IAmigoService, AmigoService>();
            services.AddScoped<IJogoService, JogoService>();
            services.AddScoped<IEnderecoService, EnderecoService>();


            //data repo
            services.AddScoped<IAmigoRepository, AmigoRepository>();
            services.AddScoped<IJogoRepository, JogoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<LocadoraGamesContext>();

        }
    }
}
