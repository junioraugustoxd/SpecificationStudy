﻿using Domain.Contracts;
using Infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
        }
    }
}
