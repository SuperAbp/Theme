using System.ComponentModel;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

public enum BootstrapFileInputTheme
{
    [Description("bs5")]
    Bootstrap5,

    [Description("explorer")]
    Explorer,

    [Description("explorer-fa")]
    ExplorerFa,

    [Description("explorer-fas")]
    ExplorerFas,

    [Description("fa")]
    FontAwesome,

    [Description("fas")]
    FontAwesome5,

    [Description("gly")]
    Glyphicons
}