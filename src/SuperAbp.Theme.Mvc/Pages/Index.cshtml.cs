using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SuperAbp.Theme.Pages;

public class IndexModel : AbpPageModel
{
    public List<SelectListItem> SelectItems = new List<SelectListItem>()
    {
        new SelectListItem("张三", "1"),
        new SelectListItem("李四", "2")
    };
}