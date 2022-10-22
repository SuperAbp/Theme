using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.Bootbox;

public class BootboxScriptContributor: BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {

        context.Files.AddIfNotContains("/libs/bootbox/bootbox.all.min.js");
    }
}