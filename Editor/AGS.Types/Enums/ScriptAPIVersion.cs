﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AGS.Types
{
    /// <summary>
    /// Defines a version of Script API, corresponding to particular AGS release
    /// </summary>
    public enum ScriptAPIVersion
    {
        [Description("3.2.1")]
        v321 = 0,
        [Description("3.3.0")]
        v330,
        [Description("3.3.4")]
        v334,
        [Description("3.3.5")]
        v335,
        [Description("3.4.0")]
        v340
    }
}
