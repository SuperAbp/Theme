using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.Bootbox
{

    [DependsOn(
        typeof(AbpAspNetCoreMvcUiBundlingAbstractionsModule),
        typeof(AbpLocalizationModule)
    )]
    public class SuperAbpAspNetCoreMvcUiBootboxModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .ScriptBundles
                    .TryAdd(BootboxBundles.Scripts.Global, bundle => bundle.AddContributors(typeof(BootboxScriptContributor)));
            });
        }
    }
}
