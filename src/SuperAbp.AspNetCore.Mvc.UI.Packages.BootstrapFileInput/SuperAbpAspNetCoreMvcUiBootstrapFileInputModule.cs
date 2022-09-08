using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapIcons;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiBundlingAbstractionsModule),
    typeof(AbpLocalizationModule),
    typeof(SuperAbpAspNetCoreMvcUiBootstrapIconModule)
)]
public class SuperAbpAspNetCoreMvcUiBootstrapFileInputModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.AddLanguagesMapOrUpdate(BootstrapFileInputScriptContributor.PackageName,
                new NameValue("zh-Hans", "zh"),
                new NameValue("zh-Hant", "zh-TW"));
            options.AddLanguageFilesMapOrUpdate(BootstrapFileInputScriptContributor.PackageName,
                new NameValue("zh-Hans", "zh"),
                new NameValue("zh-Hant", "zh-TW"));
        });
        Configure<AbpBundlingOptions>(options =>
        {
            options
                .ScriptBundles
                .TryAdd(BootstrapFileInputBundles.Scripts.Global, bundle => bundle.AddContributors(typeof(BootstrapFileInputScriptContributor)));

            options
                .StyleBundles
                .TryAdd(BootstrapFileInputBundles.Styles.Global, bundle => bundle.AddContributors(typeof(BootstrapFileInputStyleContributor)));
        });
    }
}