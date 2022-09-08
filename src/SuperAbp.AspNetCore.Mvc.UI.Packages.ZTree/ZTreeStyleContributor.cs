using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.ZTree
{
    public class ZTreeStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            var options = context
                .ServiceProvider
                .GetRequiredService<IOptions<SuperAbpZTreeOptions>>()
                .Value;

            switch (options.Theme)
            {
                default:
                case ZTreeTheme.Default:
                    context.Files.AddIfNotContains("/libs/ztree-v3/css/zTreeStyle/zTreeStyle.css");
                    break;

                case ZTreeTheme.Awesome:
                    context.Files.AddIfNotContains("/libs/ztree-v3/css/awesomeStyle/awesome.css");
                    break;

                case ZTreeTheme.Metro:
                    context.Files.AddIfNotContains("/libs/ztree-v3/css/metroStyle/metroStyle.css");
                    break;
            }
        }
    }
}