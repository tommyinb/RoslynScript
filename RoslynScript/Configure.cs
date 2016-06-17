using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoslynScript
{
    public class Configure
    {
        public string[] Imports { get; set; } = new[]
        {
            "System",
            "System.Collections.Generic",
            "System.Diagnostics",
            "System.Drawing",
            "System.IO",
            "System.Linq",
            "System.Text",
            "System.Text.RegularExpressions",
            "System.Threading.Tasks",
            "System.Windows.Forms"
        };

        public string[] References { get; set; } = new[]
        {
            "System",
            "System.Core",
            "System.Data",
            "System.Windows.Forms",
            "System.Drawing",
            "System.Xml",
            "System.Xml.Linq"
        };
    }
}
