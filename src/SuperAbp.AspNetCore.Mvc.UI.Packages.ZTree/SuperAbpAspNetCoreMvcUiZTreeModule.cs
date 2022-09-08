using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.ZTree;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiBundlingAbstractionsModule)
)]
public class SuperAbpAspNetCoreMvcUiZTreeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .TryAdd(ZTreeBundles.Styles.Global, bundle => bundle.AddContributors(typeof(ZTreeStyleContributor)));

            options
                .ScriptBundles
                .TryAdd(ZTreeBundles.Scripts.Global, bundle => bundle.AddContributors(typeof(ZTreeScriptContributor)));
        });
    }
}