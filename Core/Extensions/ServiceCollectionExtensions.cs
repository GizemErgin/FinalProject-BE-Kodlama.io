using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        //API'nin servis bağımlılıkları koleksiyonu.
        //this genişletme
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection servisCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(servisCollection);
            }
            return ServiceTool.Create(servisCollection);
        }
    }
}
