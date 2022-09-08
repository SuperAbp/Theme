using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable
{
    public class BootstrapTableStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            var options = context
               .ServiceProvider
               .GetRequiredService<IOptions<SuperAbpBootstrapTableOptions>>()
               .Value;

            context.Files.AddIfNotContains("/libs/bootstrap-table/bootstrap-table.min.css");

            if (options.Theme != BootstrapTableTheme.Bootstrap)
            {
                string description = GetDescription(options.Theme);
                context.Files.AddIfNotContains($"/libs/bootstrap-table/themes/{description}/{description}.min.css");
            }
        }

        private static string GetDescription(Enum value)
        {
            return value.GetType()
                .GetMember(value.ToString())
                .FirstOrDefault()?
                .GetCustomAttribute<DescriptionAttribute>()?
                .Description ?? throw new ArgumentException(nameof(value));
        }
    }
}