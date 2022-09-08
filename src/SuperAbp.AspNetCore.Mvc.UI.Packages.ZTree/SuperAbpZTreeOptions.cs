namespace SuperAbp.AspNetCore.Mvc.UI.Packages.ZTree;

public class SuperAbpZTreeOptions
{
    /// <summary>
    /// 主题
    /// <see cref="ZTreeTheme"/>
    /// </summary>
    public ZTreeTheme Theme { get; set; } = ZTreeTheme.Default;

    /// <summary>
    /// 启用Checkbox/Radio
    /// </summary>
    public bool EnableCheck { get; set; } = false;

    /// <summary>
    /// 启用编辑
    /// </summary>
    public bool EnableEdit { get; set; } = false;

    /// <summary>
    /// 启用隐藏
    /// </summary>
    public bool EnableHide { get; set; } = false;
}