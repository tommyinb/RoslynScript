using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynScript.Utility
{
    public class FileCommand
    {
        public string Name { get; set; }

        public string Command { get; set; }

        public string Extension { get; set; }

        public static FileCommand Get(string name)
        {
            var key = @"HKEY_CLASSES_ROOT\*\shell\" + name;

            return new FileCommand
            {
                Name = name,
                Command = Registry.GetValue(key + @"\command", string.Empty, null) as string,
                Extension = Registry.GetValue(key, "AppliesTo", null) as string
            };
        }

        public void Save()
        {
            if (Name == null) throw new InvalidOperationException();
            if (Command == null) throw new InvalidOperationException();

            var key = @"HKEY_CLASSES_ROOT\*\shell\" + Name;
            Registry.SetValue(key + @"\command", string.Empty, Command);

            if (Extension != null)
            {
                Registry.SetValue(key, "AppliesTo", Extension);
            }
        }

        public static void Remove(string name)
        {
            var key = Registry.ClassesRoot.OpenSubKey(@"*\shell\", writable: true);
            key.DeleteSubKeyTree(name, throwOnMissingSubKey: false);
        }
    }
}
