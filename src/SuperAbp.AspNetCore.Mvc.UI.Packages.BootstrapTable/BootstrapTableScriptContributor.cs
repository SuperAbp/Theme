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
using Volo.Abp.Localization;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable
{
    public class BootstrapTableScriptContributor : BundleContributor
    {
        public const string PackageName = "bootstrap-table";

        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            var options = context
                .ServiceProvider
                .GetRequiredService<IOptions<SuperAbpBootstrapTableOptions>>()
                .Value;

            context.Files.AddIfNotContains("/libs/bootstrap-table/bootstrap-table.min.js");

            if (options.Theme != BootstrapTableTheme.Bootstrap)
            {
                string description = GetDescription(options.Theme);
                context.Files.AddIfNotContains($"/libs/bootstrap-table/themes/{description}/{description}.min.js");
            }

            foreach (var extension in Enum.GetValues<BootstrapTableExtension>())
            {
                AddExtensions(context, options.Extensions, extension);
            }
        }

        /// <summary>
        /// 添加扩展
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="enableExtensions">已启用扩展</param>
        /// <param name="extension">扩展</param>
        private void AddExtensions(BundleConfigurationContext context,
            IEnumerable<BootstrapTableExtension> enableExtensions,
            BootstrapTableExtension extension)
        {
            if (enableExtensions.Contains(extension))
            {
                string description = GetDescription(extension);
                context.Files.AddIfNotContains($"/libs/bootstrap-table/extensions/{description}/bootstrap-table-{description}.min.js");
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

        public override void ConfigureDynamicResources(BundleConfigurationContext context)
        {
            var fileName = context.LazyServiceProvider.LazyGetRequiredService<IOptions<AbpLocalizationOptions>>().Value.GetCurrentUICultureLanguageFilesMap(PackageName);
            var filePath = $"/libs/bootstrap-table/locale/bootstrap-table-{fileName}.min.js";
            if (context.FileProvider.GetFileInfo(filePath).Exists)
            {
                context.Files.AddIfNotContains(filePath);
            }
        }
    }
}