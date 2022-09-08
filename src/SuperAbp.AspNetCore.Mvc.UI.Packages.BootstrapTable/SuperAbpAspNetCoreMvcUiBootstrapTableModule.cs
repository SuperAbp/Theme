using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiBundlingAbstractionsModule)
    )]
    public class SuperAbpAspNetCoreMvcUiBootstrapTableModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.AddLanguagesMapOrUpdate(BootstrapTableScriptContributor.PackageName,
                    new NameValue("en", "en-US"),
                    new NameValue("zh-Hans", "zh-CN"),
                    new NameValue("zh-Hant", "zh-TW"));
                options.AddLanguageFilesMapOrUpdate(BootstrapTableScriptContributor.PackageName,
                    new NameValue("en", "en-US"),
                    new NameValue("zh-Hans", "zh-CN"),
                    new NameValue("zh-Hant", "zh-TW"));
            });
            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .TryAdd(BootstrapTableBundles.Styles.Global, bundle => bundle.AddContributors(typeof(BootstrapTableStyleContributor)));
                options
                   .ScriptBundles
                   .TryAdd(BootstrapTableBundles.Scripts.Global, bundle => bundle.AddContributors(typeof(BootstrapTableScriptContributor)));
            });
        }
    }
}