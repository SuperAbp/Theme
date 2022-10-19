namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

public class SuperAbpBootstrapFileInputOptions
{
    /// <summary>
    /// 主题
    /// </summary>
    public BootstrapFileInputTheme Theme { get; set; } = BootstrapFileInputTheme.Bootstrap5;

    /// <summary>
    /// 启用高级预览
    /// </summary>
    public bool EnableAdvancedPreview { get; set; } = false;

    /// <summary>
    /// 启用文件定位
    /// </summary>
    public bool EnablePiexif { get; set; } = false;

    /// <summary>
    /// 启用排序
    /// </summary>
    public bool EnableSortable { get; set; } = false;
}