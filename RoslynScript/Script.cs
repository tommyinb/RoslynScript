using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using RoslynScript.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoslynScript
{
    public static class Script
    {
        public static string[] DefaultImports { get; set; } = new string[0];
        public static string[] DefaultReferences { get; set; } = new string[0];

        public static async Task<object> RunAsync(string filePath, params string[] parameters)
        {
            var initializationText = "var args = " + Code.GetCreateText(parameters) + ";";
            var initializeState = await CSharpScript.RunAsync(initializationText, ScriptOptions.Default);

            var code = File.ReadAllText(filePath);
            var header = ScriptHeader.GetHeader(code);

            var scriptOptions = ScriptOptions.Default
                .WithImports(DefaultImports)
                .WithReferences(DefaultReferences.Concat(header.References));

            var scriptState = await initializeState.ContinueWithAsync(code, scriptOptions);
            return scriptState.ReturnValue;
        }
    }
}
