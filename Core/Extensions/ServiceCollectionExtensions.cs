﻿using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection ServiceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(ServiceCollection);
            }

            return ServiceTool.Create(ServiceCollection);
        }


    }
}
