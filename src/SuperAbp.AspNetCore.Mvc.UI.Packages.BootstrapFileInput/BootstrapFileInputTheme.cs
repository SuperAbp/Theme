using System.ComponentModel;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

public enum BootstrapFileInputTheme
{
    [Description("bs5")]
    Bootstrap5,

    [Description("explorer")]
    Explorer,

    [Description("explorer-fa4")]
    ExplorerFa4,

    [Description("explorer-fa5")]
    ExplorerFa5,

    [Description("explorer-fa6")]
    ExplorerFa6,

    [Description("fa4")]
    FontAwesome,

    [Description("fa5")]
    FontAwesome5,

    [Description("fa6")]
    FontAwesome6,

    [Description("gly")]
    Glyphicons
}