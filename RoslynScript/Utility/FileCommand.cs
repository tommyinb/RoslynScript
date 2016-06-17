using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynScript.Utility
{
    public static class FileCommand
    {
        public static string Get(string extension, string name)
        {
            var key = GetKey(extension, name);
            var value = Registry.GetValue(key, string.Empty, null);
            return value as string;
        }

        public static void Set(string extension, string name, string value)
        {
            var key = GetKey(extension, name);
            Registry.SetValue(key, string.Empty, value);
        }

        private static string GetKey(string extension, string name)
        {
            var extensionName = Registry.GetValue(@"HKEY_CLASSES_ROOT\" + extension, string.Empty, null);
            if (extensionName != null)
            {
                return @"HKEY_CLASSES_ROOT\" + extensionName + @"\Shell\" + name + @"\command";
            }
            else
            {
                return @"HKEY_CLASSES_ROOT\" + extension + @"\Shell\" + name + @"\command";
            }
        }

        public static void Remove(string extension, string name)
        {
            var extensionKey = Registry.ClassesRoot.OpenSubKey(extension);
            if (extensionKey == null) return;

            var extensionName = extensionKey.GetValue(string.Empty) as string;
            var hasExtensionName = string.IsNullOrEmpty(extensionName) == false;
            if (hasExtensionName)
            {
                var extensionNameKey = Registry.ClassesRoot.OpenSubKey(extensionName);
                var shellKey = extensionNameKey.OpenSubKey("Shell", writable: true);
                if (shellKey == null) return;

                shellKey.DeleteSubKeyTree(name, throwOnMissingSubKey: false);
            }
            else
            {
                var shellKey = extensionKey.OpenSubKey("Shell", writable: true);
                if (shellKey == null) return;

                shellKey.DeleteSubKeyTree(name, throwOnMissingSubKey: false);
            }
        }
    }
}
