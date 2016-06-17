using RoslynScript.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoslynScript
{
    public static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Any())
            {
                RunScript(args);
            }
            else
            {
                RunMainForm();
            }
        }

        private static void RunScript(string[] args)
        {
            var scriptPath = args?.FirstOrDefault();
            if (scriptPath == null) throw new ArgumentException("No file provided.");

            var configure = GetConfigure();

            var parameters = args?.Skip(1)?.ToArray() ?? new string[0];

            RunScript(scriptPath, configure, parameters);
        }
        public static void RunScript(string path, Configure configure, params string[] parameters)
        {
            AttachConsole attachConsole = null;
            try
            {
                Script.DefaultImports = configure.Imports;
                Script.DefaultReferences = configure.References;

                var fullPath = Path.GetFullPath(path);
                if (File.Exists(path) == false) throw new FileNotFoundException("File \"" + fullPath + "\" does not exist.");

                var code = File.ReadAllText(fullPath);
                var header = ScriptHeader.GetHeader(code);
                if (header.HideConsole == false)
                {
                    attachConsole = new AttachConsole();
                    Console.Title = fullPath;
                }

                var runAsync = Script.RunAsync(fullPath, parameters);
                if (runAsync.Result != null)
                {
                    Console.Write("Result: ");
                    ConsoleUtil.WriteLine(ConsoleColor.Yellow, runAsync.Result);
                }
            }
            catch (Exception e)
            {
                if (attachConsole == null)
                {
                    attachConsole = new AttachConsole();
                }

                ConsoleUtil.WriteLine(ConsoleColor.Red, e);

                ConsoleUtil.WriteLine(ConsoleColor.DarkYellow, "Press enter to exit...");
                Console.ReadKey();
            }
            finally
            {
                if (attachConsole != null)
                {
                    attachConsole.Dispose();
                }
            }
        }

        private static void RunMainForm()
        {
            var form = new MainForm();
            Application.Run(form);
        }

        public static Configure GetConfigure()
        {
            var configurePath = GetConfigurePath();
            if (File.Exists(configurePath))
            {
                try
                {
                    return XmlUtil.ReadFile<Configure>(configurePath);
                }
                catch (Exception)
                {
                    return new Configure();
                }
            }
            else
            {
                return new Configure();
            }
        }
        public static string GetConfigurePath()
        {
            var programAssembly = Assembly.GetExecutingAssembly();
            var programDirectory = Path.GetDirectoryName(programAssembly.Location);
            var programFileName = Path.GetFileNameWithoutExtension(programAssembly.Location);
            return Path.Combine(programDirectory, programFileName + ".xml");
        }
    }
}
