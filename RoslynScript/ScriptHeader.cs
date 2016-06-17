using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RoslynScript
{
    public class ScriptHeader
    {
        public bool HideConsole { get; set; }

        public string[] References { get; set; }

        public static ScriptHeader GetHeader(string code)
        {
            var codeLines = Regex.Split(code, "\r?\n");
            var validLines = codeLines.Where(t => t.Length > 0).Select(t => t.Trim());
            var headerCommentLines = validLines.TakeWhile(t => t.StartsWith("//"));

            var header = new ScriptHeader();

            header.HideConsole = headerCommentLines.Contains("//console off");

            var referenceRegex = new Regex("^//import (?<name>.+);?$");
            var referenceLines = headerCommentLines.Where(t => referenceRegex.IsMatch(t));
            var referenceMatches = referenceLines.Select(t => referenceRegex.Match(t));
            header.References = referenceMatches.Select(t => t.Groups["name"].Value).ToArray();

            return header;
        }
    }
}
