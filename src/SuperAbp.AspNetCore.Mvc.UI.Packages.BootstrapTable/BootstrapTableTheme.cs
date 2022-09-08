using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAbp.AspNetCore.Mvc.UI.Packages.BootstrapTable
{
    public enum BootstrapTableTheme
    {
        [Description("bootstrap")]
        Bootstrap,

        [Description("bootstrap-table")]
        BootstrapTable,

        [Description("bulma")]
        Bulma,

        [Description("foundation")]
        Foundation,

        [Description("materialize")]
        Materialize,

        [Description("semantic")]
        Semantic
    }
}