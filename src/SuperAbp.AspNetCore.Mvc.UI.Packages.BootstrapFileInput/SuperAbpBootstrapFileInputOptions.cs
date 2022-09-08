namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapFileInput;

public class SuperAbpBootstrapFileInputOptions
{
    /// <summary>
    /// 主题
    /// </summary>
    public BootstrapFileInputTheme Theme { get; set; } = BootstrapFileInputTheme.Bootstrap5;

    public bool EnablePiexif { get; set; } = false;

    public bool EnableSortable { get; set; } = false;
}