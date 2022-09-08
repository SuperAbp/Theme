using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.Select2.Theme;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiBundlingAbstractionsModule)
)]
public class SuperAbpAspNetCoreMvcUiSelect2ThemeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .TryAdd(Select2ThemeBundles.Styles.Global, bundle => bundle.AddContributors(typeof(Select2ThemeStyleContributor)));
        });
    }
}