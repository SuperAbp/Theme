using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.Select2.Theme;

public class Select2ThemeStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains(CultureHelper.IsRtl
            ? "/libs/select2-bootstrap5-theme/select2-bootstrap-5-theme.rtl.css"
            : "/libs/select2-bootstrap5-theme/select2-bootstrap-5-theme.css");
    }
}