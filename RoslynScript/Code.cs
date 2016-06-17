using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynScript
{
    public static class Code
    {
        public static string GetCreateText(string text)
        {
            if (text == null) return "null";

            return "@\"" + text.Replace("\"", "\"\"") + "\"";
        }
        public static string GetCreateText(string[] array)
        {
            var itemScripts = array.Select(GetCreateText);
            var itemsScript = string.Join(", ", itemScripts);
            return "new string[] { " + itemsScript + " }";
        }
    }
}
