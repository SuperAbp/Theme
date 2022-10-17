using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;
using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapIcons;
using SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable;
using SuperAbp.AspNetCore.Mvc.UI.Packages.Select2.Theme;
using SuperAbp.AspNetCore.Mvc.UI.Packages.ZTree;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace SuperAbp.Theme.Mvc
{
    [DependsOn(typeof(BootstrapFileInputStyleContributor),
        typeof(BootstrapIconStyleContributor),
        typeof(BootstrapTableStyleContributor),
        typeof(Select2ThemeStyleContributor),
        typeof(ZTreeStyleContributor))]
    public class TenderingGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/global-styles.css");
        }
    }
}
