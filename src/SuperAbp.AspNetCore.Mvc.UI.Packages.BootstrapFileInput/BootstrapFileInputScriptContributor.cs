using System.ComponentModel;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

public class BootstrapFileInputScriptContributor : BundleContributor
{
    public const string PackageName = "bootstrap-fileinput";

    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        var options = context
            .ServiceProvider
            .GetRequiredService<IOptions<SuperAbpBootstrapFileInputOptions>>()
            .Value;

        if (options.EnablePiexif)
        {
            context.Files.AddIfNotContains("/libs/bootstrap-fileinput/js/plugins/piexif.min.js");
        }

        if (options.EnableSortable)
        {
            context.Files.AddIfNotContains("/libs/bootstrap-fileinput/js/plugins/sortable.min.js");
        }

        context.Files.AddIfNotContains("/libs/bootstrap-fileinput/js/fileinput.min.js");

        context.Files.AddIfNotContains($"/libs/bootstrap-fileinput/themes/{GetDescription(options.Theme)}/theme.min.js");
    }

    private static string GetDescription(Enum value)
    {
        return value.GetType()
            .GetMember(value.ToString())
            .FirstOrDefault()?
            .GetCustomAttribute<DescriptionAttribute>()?
            .Description ?? throw new ArgumentException(nameof(value));
    }

    public override void ConfigureDynamicResources(BundleConfigurationContext context)
    {
        var fileName = context.LazyServiceProvider.LazyGetRequiredService<IOptions<AbpLocalizationOptions>>().Value.GetCurrentUICultureLanguageFilesMap(PackageName);
        var filePath = $"/libs/bootstrap-fileinput/js/locales/{fileName}.js";
        if (context.FileProvider.GetFileInfo(filePath).Exists)
        {
            context.Files.AddIfNotContains(filePath);
        }
    }
}