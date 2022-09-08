using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SuperAbp.Theme;

[Dependency(ReplaceServices = true)]
public class ThemeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Theme";
}
