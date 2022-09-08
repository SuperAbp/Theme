using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapIcons;

public class BootstrapIconStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/libs/bootstrap-icons/font/bootstrap-icons.css");
    }
}