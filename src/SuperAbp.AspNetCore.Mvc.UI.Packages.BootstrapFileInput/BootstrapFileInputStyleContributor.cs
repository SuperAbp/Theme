using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapIcons;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

[DependsOn(typeof(BootstrapIconStyleContributor))]
public class BootstrapFileInputStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        var options = context
            .ServiceProvider
            .GetRequiredService<IOptions<SuperAbpBootstrapFileInputOptions>>()
            .Value;

        context.Files.AddIfNotContains(CultureHelper.IsRtl
            ? "/libs/bootstrap-fileinput/css/fileinput-rtl.min.css"
            : "/libs/bootstrap-fileinput/css/fileinput.min.css");
        switch (options.Theme)
        {
            case BootstrapFileInputTheme.Explorer:
                context.Files.AddIfNotContains("/libs/bootstrap-fileinput/themes/explorer/theme.min.css");
                break;

            case BootstrapFileInputTheme.ExplorerFa4:
                context.Files.AddIfNotContains("/libs/bootstrap-fileinput/themes/explorer-fa4/theme.min.css");
                break;

            case BootstrapFileInputTheme.ExplorerFa5:
                context.Files.AddIfNotContains("/libs/bootstrap-fileinput/themes/explorer-fa5/theme.min.css");
                break;

            case BootstrapFileInputTheme.ExplorerFa6:
                context.Files.AddIfNotContains("/libs/bootstrap-fileinput/themes/explorer-fa6/theme.min.css");
                break;
        }
    }
}