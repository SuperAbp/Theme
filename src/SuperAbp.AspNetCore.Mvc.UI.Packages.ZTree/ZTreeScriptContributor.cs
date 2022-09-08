using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.JQuery;
using Volo.Abp.Modularity;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.ZTree
{
    public class ZTreeScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.AddIfNotContains("/libs/ztree-v3/js/jquery.ztree.core.js");

            var options = context
                .ServiceProvider
                .GetRequiredService<IOptions<SuperAbpZTreeOptions>>()
                .Value;

            if (options.EnableCheck)
            {
                context.Files.AddIfNotContains("/libs/ztree-v3/js/jquery.ztree.excheck.js");
            }

            if (options.EnableEdit)
            {
                context.Files.AddIfNotContains("/libs/ztree-v3/js/jquery.ztree.exedit.js");
            }

            if (options.EnableHide)
            {
                context.Files.AddIfNotContains("/libs/ztree-v3/js/jquery.ztree.exhide.js");
            }
        }
    }
}