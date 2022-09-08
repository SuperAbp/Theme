using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapIcons;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiBundlingAbstractionsModule)
)]
public class SuperAbpAspNetCoreMvcUiBootstrapIconModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .TryAdd(BootstrapIconBundles.Styles.Global, bundle => bundle.AddContributors(typeof(BootstrapIconStyleContributor)));
        });
    }
}