using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable
{
    public class SuperAbpBootstrapTableOptions
    {
        public SuperAbpBootstrapTableOptions()
        {
            Extensions = Array.Empty<BootstrapTableExtension>();
        }

        /// <summary>
        /// 主题
        /// </summary>
        public BootstrapTableTheme Theme { get; set; } = BootstrapTableTheme.Bootstrap;

        public IEnumerable<BootstrapTableExtension> Extensions { get; set; }
    }
}